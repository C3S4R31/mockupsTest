using MauiApp1.Services;

namespace MauiApp1;

public partial class MedicalH : ContentPage
{
    public MedicalH()
    {
        InitializeComponent();
        GridCalculations.ConfigureScreenGrid(ScreenGrid);
    }
}