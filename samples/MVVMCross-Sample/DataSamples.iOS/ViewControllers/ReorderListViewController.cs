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
    [Register("ReorderListViewController")]
    [RegisterNavigation("ReorderList")]
    [ImportBinding(typeof(EditableListBindingProvider))]
    public class ReorderListViewController : UITableViewController<EditableListViewModel>
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

        public override EditingOptions EditingOptions
        {
            get
            {
                return EditingOptions.AllowEditing | EditingOptions.AllowReorder;
            }
        }
    }
}
