using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace GetStartedApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ButtonClicked(object source, RoutedEventArgs args)
    {
        Debug.WriteLine("Click!");
    }
}