using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace HabboGemini;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnButtonClick(object sender, RoutedEventArgs args)
    {
        Console.WriteLine("Hello world??");
    }
}