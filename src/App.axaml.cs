using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace HabboGemini;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();
        }

        base.OnFrameworkInitializationCompleted();
    }
}
// public partial class App : Application
// {
//     public override void Initialize()
//     {
//         AvaloniaXamlLoader.Load(this);
//     }

//     public override void OnFrameworkInitializationCompleted()
//     {
//         if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
//         {
//             desktop.MainWindow = new MainWindow();
//         }

//         base.OnFrameworkInitializationCompleted();
//     }
// }