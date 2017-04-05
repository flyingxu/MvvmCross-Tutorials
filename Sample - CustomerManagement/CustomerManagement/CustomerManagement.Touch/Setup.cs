using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;
using MvvmCross.Dialog.iOS;
using MvvmCross.iOS.Platform;
using MvvmCross.Core.ViewModels;
using CustomerManagement.Core;
using CustomerManagement.Core.Interfaces;
using CustomerManagement.Core.ViewModels;
using CustomerManagement.Touch.Views;

namespace CustomerManagement.Touch
{
    public class Setup
        : MvxIosDialogSetup
    {
        private CustomerManagementPresenter _presenter;

        public Setup(MvxApplicationDelegate applicationDelegate, CustomerManagementPresenter presenter)
            : base(applicationDelegate, presenter)
        {
            _presenter = presenter;
        }

        protected override IMvxApplication CreateApp()
        {
            var app = new App();
            return app;
        }

		protected override void AddPluginsLoaders(MvxLoaderPluginRegistry registry)
		{
			base.AddPluginsLoaders(registry);
		}

		protected override void InitializeLastChance ()
		{
			base.InitializeLastChance ();

            Mvx.RegisterSingleton<IViewModelCloser>(_presenter);
            MvvmCross.Plugins.File.PluginLoader.Instance.EnsureLoaded();
            MvvmCross.Plugins.DownloadCache.PluginLoader.Instance.EnsureLoaded();
		}
    }
}