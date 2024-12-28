using Android.App;
using Android.Content.PM;
using Android.OS;

namespace BlazorHybridManageStatus
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            if(Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#FF5722"));
                // Window.DecorView.SystemUiFlags = Android.Views.SystemUiFlags.LightStatusBar;
                Window.DecorView.SystemUiFlags = 0;
            }
        }
    }
}
