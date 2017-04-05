using MvvmCross.Binding.iOS.Views;
using Foundation;
using UIKit;

namespace CustomerManagement.Touch.Views
{
    public class CustomerListTableViewSource : MvxTableViewSource
    {
        static readonly NSString CellIdentifier = new NSString("ClientCell");

        public CustomerListTableViewSource(UITableView tableView) 
            : base(tableView)
        {
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            if (cell == null)
            {
                cell = new CustomerListTableViewCell(UITableViewCellStyle.Subtitle, CellIdentifier);
                cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
            }
            return cell;
        }

        public string TitleForHeader(UITableView tableView, int section)
        {
            return string.Empty;
        }
    }
}