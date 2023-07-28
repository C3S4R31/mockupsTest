namespace MauiApp1;

public partial class AppShell : Shell
{
    public string DynamicTitle { get; set; } = "Title";
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(MyAppointments), typeof(MyAppointments));
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
    }
}
