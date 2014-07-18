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
    [Register("FilterListViewController")]
    [ImportBinding(typeof(SimpleListBindingProvider))]
    public class FilterListViewController : UITableViewController<FilterListViewModel>
    {
        public override TableViewCellStyle CellStyle
        {
            get
            {
                return TableViewCellStyle.Subtitle;
            }
        }

        public override bool ShowGroupHeader
        {
            get
            {
                return true;
            }
        }

        public override bool AllowSearching
        {
            get
            {
                return true;
            }
        }
    }
}
