using MvvmCross.Droid.Views;
using MvvmCross.Binding.Droid.Views;
using MvvmCross.Core.ViewModels;

namespace CustomerManagement.Droid.Views
{
    public abstract class BaseView<TViewModel>
        : MvxActivity
        where TViewModel : class, IMvxViewModel
    {
        public new TViewModel ViewModel
        {
            get { return (TViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }
    }
}