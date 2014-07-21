// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DataSamples.iOS
{
	[Register ("CustomTableCell")]
	partial class CustomTableCell
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView ImageView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TextLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel DetailTextLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel PriceLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ImageView != null) {
				ImageView.Dispose ();
				ImageView = null;
			}

			if (TextLabel != null) {
				TextLabel.Dispose ();
				TextLabel = null;
			}

			if (DetailTextLabel != null) {
				DetailTextLabel.Dispose ();
				DetailTextLabel = null;
			}

			if (PriceLabel != null) {
				PriceLabel.Dispose ();
				PriceLabel = null;
			}
		}
	}
}
