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
    [Register("RightDetailListViewController")]
    [ImportBinding(typeof(CategoryListBindingProvider))]
    [RegisterNavigation("RightDetailCellStyle")]
    public class RightDetailListViewController : UITableViewController<CategoryListViewModel>
    {
        public override TableViewCellStyle CellStyle
        {
            get
            {
                return TableViewCellStyle.RightDetail;
            }
        }
    }
}
