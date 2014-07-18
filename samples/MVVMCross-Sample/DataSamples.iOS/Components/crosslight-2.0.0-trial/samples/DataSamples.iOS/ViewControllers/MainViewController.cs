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
    [Register("MainViewController")]
    [ImportBinding(typeof(NavigationBindingProvider))]
    public class MainViewController : UITableViewController<NavigationViewModel>
    {
        public override UITableViewStyle TableViewStyle
        {
            get
            {
                return UITableViewStyle.Grouped;
            }
        }

        public override TableViewInteraction InteractionMode
        {
            get
            {
                return TableViewInteraction.Navigation;
            }
        }

        public override bool ShowGroupHeader
        {
            get
            {
                return true;
            }
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            var label = new UILabel();
            label.Text = "© 2013 Intersoft Solutions";
            label.BackgroundColor = UIColor.Clear;
            label.TextColor = UIColor.DarkGray;
            label.ShadowColor = UIColor.White.ColorWithAlpha(0.8f);
            label.ShadowOffset = new SizeF(1, 1);
            label.Font = UIFont.SystemFontOfSize(14f);
            label.SizeToFit();
            label.Frame = new RectangleF(label.Frame.Left, label.Frame.Top, label.Frame.Width, label.Frame.Height + 8);
            label.Center = new PointF(this.View.Bounds.Width / 2, label.Bounds.Height / 2);

            // set TableView footer
            this.TableView.TableFooterView = label;

            // set navigation title
            this.NavigationItem.Title = "Data Samples";
        }
    }
}
