using System.Reflection;

namespace ISIvanti.Shared.Utilities;

public class Utilities
{
    public static string GetVersionAsString()
    {
        return Assembly.GetCallingAssembly().GetName().Version?.ToString() ?? "Unknown";
    }

    public static bool IsDebugMode()
    {
#if DEBUG
        return true;
#else
        return false;
#endif
    }
}
