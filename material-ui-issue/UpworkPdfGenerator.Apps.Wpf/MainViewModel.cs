using CommunityToolkit.Mvvm.ComponentModel;
using System.Drawing;

namespace UpworkPdfGenerator.Apps.Wpf;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private System.Drawing.Color color = System.Drawing.Color.Red;

    [ObservableProperty]
    private System.Drawing.Color color2 = System.Drawing.Color.Blue;

    partial void OnColorChanged(Color value)
    {
        Color2 = value;
    }
}
