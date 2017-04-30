using CoreGraphics;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Foundation;
using UIKit;
using ObjCRuntime;

namespace Babel.iOS.Views
{
    [Register("SecondView")]
    public class SecondView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView() { BackgroundColor = UIColor.White };
            base.ViewDidLoad();

            // ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
                EdgesForExtendedLayout = UIRectEdge.None;
            
            var label = AddLabel(0);
            this.BindLanguage(label, "Text", "PageTitle");
            label = AddLabel(1);
            this.BindLanguage(label, "Text", "Body1");
            label = AddLabel(2);
            this.BindLanguage(label, "Text", "Body2");
        }

        private UILabel AddLabel(int count)
        {
            var label = new UILabel(new CGRect(10, 10 + count * 40, 300, 40));
            Add(label);
            return label;
        }
    }
}