using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using DataSamples.ViewModels;

namespace DataSamples.iOS.ViewControllers
{
    [Register("CustomStyleListViewController")]
    [RegisterNavigation("CustomCellStyle")]
    [ImportBinding(typeof(CustomListBindingProvider))]
    public class CustomStyleListViewController : UITableViewController<SimpleListViewModel>
    {
        public override TableViewCellStyle CellStyle
        {
            get
            {
                return TableViewCellStyle.Custom;
            }
        }

        public override UIViewTemplate CellTemplate
        {
            get
            {
                return new UIViewTemplate(CustomTableCell.Nib);
            }
        }

        public override string CellIdentifier
        {
            get
            {
                return "CustomTableCell";
            }
        }

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();

            // Use a custom table source with customized row height
            this.TableSource = new CustomTableSource(this, this.GetItemBinding(), this.ViewModel);
        }

        private class CustomTableSource : ObservableTableSource
        {
            internal CustomTableSource(UITableViewController viewController, ItemBindingDescription bindingDescription, IViewModel viewModel)
                : base(viewController, bindingDescription, viewModel)
            {
            }

            public override float GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
            {
                return 75;
            }
        }
    }
}
