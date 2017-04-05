using MvvmCross.Platform.Platform;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Core.ViewModels;
using CustomerManagement.Core.Interfaces;
using UIKit;

namespace CustomerManagement.Touch
{
    public class CustomerManagementPresenter 
        : MvxIosViewPresenter
          , IViewModelCloser
    {
        public CustomerManagementPresenter(UIApplicationDelegate applicationDelegate, UIWindow window) 
            : base(applicationDelegate, window)
        {
        }

        public void RequestClose(IMvxViewModel viewModel)
        {
            var nav = MasterNavigationController;
            var top = nav.TopViewController;
            var view = top as IMvxIosView;

            if (view == null)
            {
                MvxTrace.Trace("request close ignored for {0} - no current view controller", viewModel.GetType().Name);
                return;
            }

            if (view.ViewModel != viewModel)
            {
                MvxTrace.Trace("request close ignored for {0} - current view controller is registered for a different viewmodel of type {1}", viewModel.GetType().Name, view.ViewModel.GetType().Name);
                return;
            }

            MvxTrace.Trace("request close for {0} - will close current view controller {1}", viewModel.GetType().Name, view.GetType().Name);
            nav.PopViewController(true);
        }
    }
}