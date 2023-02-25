using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Gotrays.Views;

public partial class TitleBar : UserControl
{
    public TitleBar()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    private void Close_OnClick(object? sender, RoutedEventArgs e)
    {
        Environment.Exit(0);
    }

    private void ToggleButton_OnIsCheckedChanged(object? sender, RoutedEventArgs e)
    {
        var app = Application.Current;
        if (app is not null)
        {
            var theme = app.ActualThemeVariant;
            
            app.RequestedThemeVariant = theme == ThemeVariant.Dark ? ThemeVariant.Light : ThemeVariant.Dark;
        }
    }
}