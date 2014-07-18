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
    [Register("BatchUpdateViewController")]
    [RegisterNavigation("BatchUpdate")]
    [ImportBinding(typeof(EditableListBindingProvider))]
    public class BatchUpdateViewController : UITableViewController<EditableListViewModel>
    {
        public override TableViewCellStyle CellStyle
        {
            get
            {
                return TableViewCellStyle.Subtitle;
            }
        }

        public override ImageSettings CellImageSettings 
        {
            get 
            {
                return DefaultSettings.ImageSettings;
            }
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            // Configure Toolbar
            UIBarButtonItem batchUpdateCommand = new UIBarButtonItem();
            batchUpdateCommand.Style = UIBarButtonItemStyle.Bordered;
            batchUpdateCommand.Title = "Batch Update";

            this.SetToolbarItems(new UIBarButtonItem[] { batchUpdateCommand }, false);
            this.RegisterViewIdentifier("BatchUpdateButton", batchUpdateCommand);

            // Show Toolbar
            this.NavigationController.SetToolbarHidden(false, true);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            // Hide Toolbar
            this.NavigationController.SetToolbarHidden(true, true);
        }
    }
}
