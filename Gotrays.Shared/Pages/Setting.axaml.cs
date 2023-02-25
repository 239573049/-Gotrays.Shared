using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Gotrays.Pages;

public partial class Setting : UserControl
{
    public Setting()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}