
using Android.App;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Views;

namespace CustomerManagement.Droid
{
    [Activity(Label = "SplashScreenActivity", Theme = "@android:style/Theme.Black.NoTitleBar", MainLauncher = true, Icon = "@drawable/icon", NoHistory = true)]
    public class SplashScreenActivity
        : MvxSplashScreenActivity
    {
        public SplashScreenActivity()
            : base(Resource.Layout.Splash)
        {
        }
    }
}