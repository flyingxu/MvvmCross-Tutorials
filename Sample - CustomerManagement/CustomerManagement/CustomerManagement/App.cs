using MvvmCross.Platform;
using MvvmCross.Core.ViewModels;
using CustomerManagement.Core.Models;
using CustomerManagement.Core.ViewModels;

namespace CustomerManagement.Core
{
    public class App 
        : MvxApplication
        
    {
        public App()
        {
            MvvmCross.Plugins.File.PluginLoader.Instance.EnsureLoaded();
            MvvmCross.Plugins.ResourceLoader.PluginLoader.Instance.EnsureLoaded();

            // set up the model
            var dataStore = new SimpleDataStore();
            Mvx.RegisterSingleton<IDataStore>(dataStore);

            // set the start object
            RegisterAppStart<CustomerListViewModel>();
        }
    }
}