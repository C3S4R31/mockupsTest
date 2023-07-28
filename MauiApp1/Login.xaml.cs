using MauiApp1.Services;

namespace MauiApp1;

public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
        GridCalculations.ConfigureScreenGrid(ScreenGrid);

    }


    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(MyAppointments)}");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }
}