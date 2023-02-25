using Avalonia.Controls;
using Avalonia.Media;

namespace Gotrays.Views;

public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
        
    }

    public override void Render(DrawingContext context)
    {
        base.Render(context);
        var titleBar = this.Find<TitleBar>("TitleBar");
        titleBar.Window = this;
    }
}