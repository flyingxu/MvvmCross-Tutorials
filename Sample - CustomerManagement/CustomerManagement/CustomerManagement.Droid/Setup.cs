using System;
using System.Collections.Generic;
using System.Reflection;
using Android.Content;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using MvvmCross.Droid.Platform;
using MvvmCross.Binding.Droid;
using MvvmCross.Plugins.Json;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using CustomerManagement.Core;
using CustomerManagement.Core.Interfaces;
using CustomerManagement.Core.ViewModels;

namespace CustomerManagement.Droid
{
    public class Setup 
        : MvxAndroidSetup
    {
        public Setup(Context applicationContext) 
            : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            var app =  new App();
            return app;
        }

        protected override void InitializeLastChance()
        {
            var closer = new SimpleDroidViewModelCloser();
            Mvx.RegisterSingleton<IViewModelCloser>(closer);
            base.InitializeLastChance();
        }
    }
}