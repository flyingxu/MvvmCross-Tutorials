using System.Windows;
using MvvmCross.Platform;
using MvvmCross.Core.ViewModels;

namespace TwitterSearch.UI.Wpf
{
    public partial class App
        : Application        
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var start = Mvx.Resolve<IMvxAppStart>();
            start.Start();
        }
    }
}
