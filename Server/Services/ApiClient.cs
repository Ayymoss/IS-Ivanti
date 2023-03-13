using System.Net;
using ISIvanti.Server.Dtos;
using ISIvanti.Server.Interfaces;
using ISIvanti.Server.Interfaces.Ivanti;
using ISIvanti.Server.Utilities;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Account;
using RestEase;

namespace ISIvanti.Server.Services;

public class ApiClient
{
    private readonly ILogger<ApiClient> _logger;
    private readonly Configuration _config;
    private readonly UserManager _userManager;

    public ApiClient(ILogger<ApiClient> logger, Configuration config, UserManager userManager)
    {
        _logger = logger;
        _config = config;
        _userManager = userManager;
    }

    public IvantiApi? GetIvantiApiAsync(Guid identity)
    {
        var user = _userManager.GetUserCredentials(identity);
        if (user is null) return null;
        var apiHost = $"https://{_config.HostAndPort}/st/console/api/v1.0";
        var credentials = new NetworkCredential(user.UserName, user.Password, _config.Domain);
        var handler = new HttpClientHandler {Credentials = credentials};
        var api = RestClient.For<IIvantiApi>(apiHost, handler);
        return new IvantiApi(api, _logger);
    }
}
