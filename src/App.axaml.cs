using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using HabboGemini.Infrastructure.Database;
using HabboGemini.Presentation.ViewModels;
using HabboGemini.Presentation.Views;

using Microsoft.Extensions.DependencyInjection;

namespace HabboGemini;

public partial class App : Application
{
    public static IServiceProvider Services { get; private set; } = null!;
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);

        var servicesCollection = new ServiceCollection();
        
        ConfigureServices(servicesCollection);

        Services = servicesCollection.BuildServiceProvider();
    }

    private void ConfigureServices(IServiceCollection collection)
    {
        collection.AddSingleton(new DatabaseConnector(""));
        collection.AddSingleton<MainViewModel>();

        collection.AddTransient<MainWindow>();
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainViewModel()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
