namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }
    private void SignUpBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new NewPage1());

    }
}