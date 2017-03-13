using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using MvvmCross.Core.ViewModels;
using TwitterSearch.Core.ViewModels;

namespace TwitterSearch.Core
{
    public class TwitterSearchApp
        : MvxApplication        
    {
        public TwitterSearchApp()
        {
            InitaliseServices();
            InitialiseStartNavigation();
            InitialisePlugIns();
        }

        private void InitaliseServices()
        {
            CreatableTypes()
                .EndingWith("SearchProvider")
                .AsInterfaces()
                .RegisterAsSingleton();
        }

        private void InitialiseStartNavigation()
        {
            RegisterAppStart<HomeViewModel>();
        }

        private void InitialisePlugIns()
        {
            MvvmCross.Plugins.Visibility.PluginLoader.Instance.EnsureLoaded();
        }
    }
}
