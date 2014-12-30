using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace CrittercismIOS
{

	[BaseType (typeof (NSObject))]
	internal partial interface Crittercism {

		[Static, Export ("leaveBreadcrumb:")]
		void LeaveBreadcrumb (string breadcrumb);

		[Static, Export ("logHandledException:")]
		bool LogHandledException (NSException exception);

		[Static, Export ("getUserUUID")]
		string UserUUID { get; }

		[Static, Export ("Username")]
		string Username { set; }
	}

}

