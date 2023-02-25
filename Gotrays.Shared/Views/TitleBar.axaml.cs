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
    public static readonly AvaloniaProperty<string> TitleProperty =
        AvaloniaProperty.Register<MainWindow, string>(nameof(Title));

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly AvaloniaProperty<Window> WindowProperty =
        AvaloniaProperty.Register<MainWindow, Window>(nameof(WindowProperty));

    public Window Window
    {
        get => (Window)GetValue(WindowProperty);
        set => SetValue(WindowProperty, value);
    }

    
    public TitleBar()
    {
        InitializeComponent();
        DataContext = this;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    private void Close_OnClick(object? sender, RoutedEventArgs e)
    {
        Window?.Close();
    }

    private void ToggleButton_OnIsCheckedChanged(object? sender, RoutedEventArgs e)
    {
        var app = Application.Current;
        if (app is null) return;
        
        var theme = app.ActualThemeVariant;
            
        app.RequestedThemeVariant = theme == ThemeVariant.Dark ? ThemeVariant.Light : ThemeVariant.Dark;
    }
}