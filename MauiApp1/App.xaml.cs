using MauiApp1.Services;

namespace MauiApp1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
        {
#if __ANDROID__
        handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#endif



        });
    }
}
