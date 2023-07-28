using MauiApp1.Services;

namespace MauiApp1;

public partial class Report : ContentPage
{
    public Report()
    {
        InitializeComponent();
        GridCalculations.ConfigureScreenGrid(ScreenGrid);
    }
}
