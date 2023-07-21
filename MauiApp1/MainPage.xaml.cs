using MauiApp1.Services;
namespace MauiApp1;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        GridCalculations.ConfigureScreenGrid(ScreenGrid);

        /*if (Device.RuntimePlatform == Device.WinUI)
        {
            imagenlogo.Source = "dotnet_bot.png";
            CounterBtn.TextColor = Color.FromRgb(0, 0, 0);
        }
        else
        {
            imagenlogo.Source = "dotnet_bot.svg";
            CounterBtn.TextColor = Color.FromRgb(0, 255, 0);
        }*/
        //Navigation.PushAsync(new TestPage());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }
}

