// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Sample.iOS
{
	[Register ("Sample_iOSViewController")]
	partial class Sample_iOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton BeginUserflowButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CrashButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton EndUserflowButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton FailUserflowButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton GetUserflowValueButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton HandledExceptionButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton httpGetButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton LeaveBreadcrumbButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton LogNetworkRequestButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SetMetadataButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SetUserflowValueButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SetUsernameButton { get; set; }

		[Action ("BeginUserflowButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BeginUserflowButton_TouchUpInside (UIButton sender);

		[Action ("CrashButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void CrashButton_TouchUpInside (UIButton sender);

		[Action ("EndUserflowButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void EndUserflowButton_TouchUpInside (UIButton sender);

		[Action ("FailUserflowButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void FailUserflowButton_TouchUpInside (UIButton sender);

		[Action ("GetUserflowValueButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void GetUserflowValueButton_TouchUpInside (UIButton sender);

		[Action ("HandledExceptionButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void HandledExceptionButton_TouchUpInside (UIButton sender);

		[Action ("HttpGetButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void HttpGetButton_TouchUpInside (UIButton sender);

		[Action ("LeaveBreadcrumbButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void LeaveBreadcrumbButton_TouchUpInside (UIButton sender);

		[Action ("LogNetworkRequestButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void LogNetworkRequestButton_TouchUpInside (UIButton sender);

		[Action ("SetMetadataButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void SetMetadataButton_TouchUpInside (UIButton sender);

		[Action ("SetUserflowValueButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void SetUserflowValueButton_TouchUpInside (UIButton sender);

		[Action ("SetUsernameButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void SetUsernameButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (BeginUserflowButton != null) {
				BeginUserflowButton.Dispose ();
				BeginUserflowButton = null;
			}
			if (CrashButton != null) {
				CrashButton.Dispose ();
				CrashButton = null;
			}
			if (EndUserflowButton != null) {
				EndUserflowButton.Dispose ();
				EndUserflowButton = null;
			}
			if (FailUserflowButton != null) {
				FailUserflowButton.Dispose ();
				FailUserflowButton = null;
			}
			if (GetUserflowValueButton != null) {
				GetUserflowValueButton.Dispose ();
				GetUserflowValueButton = null;
			}
			if (HandledExceptionButton != null) {
				HandledExceptionButton.Dispose ();
				HandledExceptionButton = null;
			}
			if (httpGetButton != null) {
				httpGetButton.Dispose ();
				httpGetButton = null;
			}
			if (LeaveBreadcrumbButton != null) {
				LeaveBreadcrumbButton.Dispose ();
				LeaveBreadcrumbButton = null;
			}
			if (LogNetworkRequestButton != null) {
				LogNetworkRequestButton.Dispose ();
				LogNetworkRequestButton = null;
			}
			if (SetMetadataButton != null) {
				SetMetadataButton.Dispose ();
				SetMetadataButton = null;
			}
			if (SetUserflowValueButton != null) {
				SetUserflowValueButton.Dispose ();
				SetUserflowValueButton = null;
			}
			if (SetUsernameButton != null) {
				SetUsernameButton.Dispose ();
				SetUsernameButton = null;
			}
		}
	}
}
