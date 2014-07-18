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
    [Register("ListNavigationViewController")]
    [RegisterNavigation("ListNavigation")]
    public class ListNavigationViewController : SubtitleImageStyleListViewController
    {
        public override TableViewInteraction InteractionMode
        {
            get
            {
                return TableViewInteraction.Navigation;
            }
        }
    }
}
