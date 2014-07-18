using System;
using Intersoft.Crosslight.iOS;
using DataSamples.ViewModels;
using MonoTouch.Foundation;
using Intersoft.Crosslight;
using MonoTouch.UIKit;
using System.Drawing;

namespace DataSamples.iOS
{
    [Register("AboutViewController")]
    [ImportBinding(typeof(AboutBindingProvider))]
    public partial class AboutViewController : UIViewController<AboutViewModel>
    {
        public AboutViewController()
            : base("AboutView", null)
        {
        }

        public override bool AutoFitContentSize
        {
            get
            {
                return true;
            }
        }
    }
}

