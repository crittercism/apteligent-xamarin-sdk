// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DataSamples.iOS
{
    partial class AboutViewController
    {
        [Outlet]
        MonoTouch.UIKit.UILabel GreetingLabel { get; set; }

        [Outlet]
        MonoTouch.UIKit.UIButton LearnMoreButton { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (GreetingLabel != null)
            {
                GreetingLabel.Dispose();
                GreetingLabel = null;
            }

            if (LearnMoreButton != null)
            {
                LearnMoreButton.Dispose();
                LearnMoreButton = null;
            }
        }
    }
}
