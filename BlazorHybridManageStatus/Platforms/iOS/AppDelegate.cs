using Foundation;
using UIKit;

namespace BlazorHybridManageStatus
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            if(UIDevice.CurrentDevice.CheckSystemVersion(13,0))
            {
                UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;
                var statusBarFrame = UIApplication.SharedApplication.KeyWindow.WindowScene?
                    .StatusBarManager?.StatusBarFrame;
                if (statusBarFrame.HasValue)
                {
                    var statusBar = new UIView(statusBarFrame.Value)
                    {
                        BackgroundColor = UIColor.FromRGB(255, 87, 34)
                    };
                    UIApplication.SharedApplication.KeyWindow.AddSubview(statusBar);
                }
               
            }
            return base.FinishedLaunching(application, launchOptions);
        }
    }
}
