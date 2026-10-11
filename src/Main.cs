using System;
using Avalonia;

namespace HabboGemini;

public class Program
{
    [STAThread]
    public static void Main(string[] args) => AppBuilder
        .Configure<App>()
        .UsePlatformDetect()
        .WithDeveloperTools()
        .WithInterFont()
        .LogToTrace()
        .StartWithClassicDesktopLifetime(args);
}
