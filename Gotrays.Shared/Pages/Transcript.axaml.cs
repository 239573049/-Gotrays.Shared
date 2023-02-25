using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Gotrays.Shared.Views;

namespace Gotrays.Pages;

public partial class Transcript : UserControl
{
    public Transcript()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Create_OnClick(object? sender, RoutedEventArgs e)
    {
        var dialog = new Dialog();
        dialog.Show();
        
    }
}