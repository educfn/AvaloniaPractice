using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
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
        Debug.WriteLine($"Click! Celsius={celsius.Text}");

        if (Double.TryParse(celsius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            fahrenheit.Text = F.ToString("0.0");
        }
        else 
        {
            celsius.Text = "0";
            fahrenheit.Text = "0";
        }
    }

    public void TextBoxChanged(object source, TextChangedEventArgs args)
    {
        Debug.WriteLine($"Click! Celsius={celsius.Text}");

        if (Double.TryParse(celsius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            fahrenheit.Text = F.ToString("0.0");
        }
        else
        {
            celsius.Text = "0";
            fahrenheit.Text = "0";
        }
    }
}