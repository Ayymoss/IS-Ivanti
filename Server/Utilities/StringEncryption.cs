using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Text;
using ISIvanti.Shared.Dtos;

namespace ISIvanti.Server.Utilities;
public class StringEncryption
{
    private readonly ILogger<StringEncryption> _logger;
    private readonly ConcurrentDictionary<string, byte[]> _saltCache = new();
    private readonly string _password;

    public StringEncryption(Configuration config, ILogger<StringEncryption> logger)
    {
        _logger = logger;
        _password = config.EncryptionPassword;
    }

    // This function likely has a memory leak. It's not a big deal for this application, but it's something to be aware of.
    // The salt cache is never cleared, so it will grow indefinitely.
    private IEnumerable<byte> GetSalt(string key)
    {
        if (_saltCache.TryGetValue(key, out var salt)) return salt;
        var newSalt = new byte[16];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(newSalt);
        _saltCache.TryAdd(key, newSalt);
        return newSalt;
    }

    public string? Encrypt(LoginRequestDto? login)
    {
        if (string.IsNullOrEmpty(login?.Password) || string.IsNullOrEmpty(login.UserName)) return null;

        var salt = GetSalt(login.UserName).ToArray();
        byte[] encryptedBytes;

        using (var aesAlg = Aes.Create())
        {
            var key = new Rfc2898DeriveBytes(_password, salt, 10_000, HashAlgorithmName.SHA256);
            aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
            aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

            using (var encryptor = aesAlg.CreateEncryptor())
            {
                var plainBytes = Encoding.UTF8.GetBytes(login.Password);

                using (var msEncrypt = new MemoryStream())
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                    csEncrypt.FlushFinalBlock();
                    encryptedBytes = msEncrypt.ToArray();
                }
            }
        }

        return Convert.ToBase64String(encryptedBytes);
    }

    public string? Decrypt(LoginRequestDto? login)
    {
        if (string.IsNullOrEmpty(login?.Password) || string.IsNullOrEmpty(login.UserName)) return null;

        string? decrypted = null;
        try
        {
            var salt = GetSalt(login.UserName).ToArray();
            var cipherBytes = Convert.FromBase64String(login.Password);

            using var aesAlg = Aes.Create();
            var key = new Rfc2898DeriveBytes(_password, salt, 10000, HashAlgorithmName.SHA256);
            aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
            aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

            using var decryptor = aesAlg.CreateDecryptor();
            using var msDecrypt = new MemoryStream(cipherBytes);
            using var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
            using var srDecrypt = new StreamReader(csDecrypt);
            decrypted = srDecrypt.ReadToEnd();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Failed to decrypt password: {Name}", login.UserName);
        }

        return decrypted;
    }
}
