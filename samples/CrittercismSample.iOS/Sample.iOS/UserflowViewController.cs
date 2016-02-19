using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CrittercismIOS;

namespace Sample.iOS
{
	partial class UserflowViewController : UIViewController
	{
		public UserflowViewController (IntPtr handle) : base (handle)
		{
		}
			
		partial void BeginPaymentButton_TouchUpInside (UIButton sender)
		{
			Crittercism.BeginUserflow("Payment");
		}

		partial void EndPaymentButton_TouchUpInside (UIButton sender)
		{
			Crittercism.EndUserflow("Payment");
		}

		partial void FailPaymentButton_TouchUpInside (UIButton sender)
		{
			Crittercism.FailUserflow("Payment");
		}

		partial void SetPaymentValueButton_TouchUpInside (UIButton sender)
		{
			Crittercism.SetUserflowValue("Payment", 999);
		}

		partial void BeginLoginButton_TouchUpInside (UIButton sender)
		{
			Crittercism.BeginUserflow("Login");
		}

		partial void EndLoginButton_TouchUpInside (UIButton sender)
		{
			Crittercism.EndUserflow("Login");
		}

		partial void FailLoginButton_TouchUpInside (UIButton sender)
		{
			Crittercism.FailUserflow("Login");
		}
			
		partial void SetLoginValueButton_TouchUpInside (UIButton sender)
		{
			Crittercism.SetUserflowValue("Login", 5);
		}
	}
}
