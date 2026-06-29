namespace WslStudio.Tests.Application.Wsl;

internal static class WslStatusAndVersionFixtures
{
    public const string StatusOutput = """
    Default Distribution: Ubuntu
    Default Version: 2
    Kernel version: 6.18.35.2-1
    """;

    public const string VersionOutput = """
    WSL version: 2.9.3.0
    Kernel version: 6.18.35.2-1
    WSLg version: 1.0.79
    Windows version: 10.0.26300.8758
    """;
}
