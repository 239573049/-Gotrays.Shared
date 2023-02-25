using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Gotrays.Views;

namespace Gotrays.Shared.Views;

public partial class Dialog : Window
{
    public Dialog()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void Render(DrawingContext context)
    {
        base.Render(context);
        
        var titleBar = this.Find<TitleBar>("TitleBar");
        titleBar.Window = this;
    }
}