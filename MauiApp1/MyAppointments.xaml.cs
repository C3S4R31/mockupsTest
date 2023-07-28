using System.Diagnostics;

namespace MauiApp1;

public partial class MyAppointments : ContentPage
{
    public MyAppointments()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MedicalH());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Report());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Title", "Text", "Confirm", "Cancel");
    }
}