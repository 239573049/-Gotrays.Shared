using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Gotrays.Pages;

public partial class ImageRecords : UserControl
{
    public ImageRecords()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}