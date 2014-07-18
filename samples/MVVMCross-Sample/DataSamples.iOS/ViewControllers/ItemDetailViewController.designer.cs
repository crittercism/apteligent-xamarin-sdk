// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DataSamples.iOS
{
	[Register ("ItemDetailViewController")]
	partial class ItemDetailViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel NameLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel LocationLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel PriceLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView ImageView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel DescriptionLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel CategoryLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel QtyLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel PurchaseDateLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (NameLabel != null) {
				NameLabel.Dispose ();
				NameLabel = null;
			}

			if (LocationLabel != null) {
				LocationLabel.Dispose ();
				LocationLabel = null;
			}

			if (PriceLabel != null) {
				PriceLabel.Dispose ();
				PriceLabel = null;
			}

			if (ImageView != null) {
				ImageView.Dispose ();
				ImageView = null;
			}

			if (DescriptionLabel != null) {
				DescriptionLabel.Dispose ();
				DescriptionLabel = null;
			}

			if (CategoryLabel != null) {
				CategoryLabel.Dispose ();
				CategoryLabel = null;
			}

			if (QtyLabel != null) {
				QtyLabel.Dispose ();
				QtyLabel = null;
			}

			if (PurchaseDateLabel != null) {
				PurchaseDateLabel.Dispose ();
				PurchaseDateLabel = null;
			}
		}
	}
}
