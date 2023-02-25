using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

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
}