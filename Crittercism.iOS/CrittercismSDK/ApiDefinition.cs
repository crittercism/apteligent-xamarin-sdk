using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CrittercismSDK
{
	public enum CRFilterType : uint { ScrubQuery, Blacklist, PreserveQuery }

	[Model, BaseType (typeof (NSObject))]
	public partial interface CrittercismDelegate {

		[Export ("crittercismDidCrashOnLastLoad")]
		void CrittercismDidCrashOnLastLoad ();
	}

	[BaseType (typeof (NSObject))]
	public partial interface Crittercism {

		[Static, Export ("enableWithAppID:")]
		void EnableWithAppID (string appId);

		[Static, Export ("enableWithAppID:andDelegate:")]
		void EnableWithAppID (string appId, CrittercismDelegate critterDelegate);

		[Static, Export ("enableWithAppID:andDelegate:andURLFilters:")]
		void EnableWithAppID (string appId, CrittercismDelegate critterDelegate, NSObject [] filters);

		[Static, Export ("enableWithAppID:andURLFilters:")]
		void EnableWithAppID (string appId, NSObject [] filters);

		[Static, Export ("enableWithAppID:andDelegate:andURLFilters:disableInstrumentation:")]
		void EnableWithAppID (string appId, CrittercismDelegate critterDelegate, NSObject [] filters, bool disableInstrumentation);

		//[Static, Export ("addFilter:")]
		//void AddFilter (CRFilter filter);

		[Static, Export ("leaveBreadcrumb:")]
		void LeaveBreadcrumb (string breadcrumb);

		[Static, Export ("asyncBreadcrumbMode")]
		bool AsyncBreadcrumbMode { set; }

		//[Static, Export ("updateLocation:")]
		//void UpdateLocation (CLLocation location);

		[Static, Export ("logHandledException:")]
		bool LogHandledException (NSException exception);

		// MAS TODO
		// https://github.com/crittercism/crittercism-unity-ios/blob/feature/exception-cleanup/Plugins/Crittercism_IOS_Scripts/CrittercismIOS.cs#L169 
		//Crittercism_LogUnhandledException (name, message, stacktrace);
		//Crittercism_LogUnhandledException( string name, string message, string stacktrace);

		[Static, Export ("logHandledException:")]
		bool LogHandledException(string name, string reason, string stack);

		[Static, Export ("logUnhandledException:")]
		bool LogUnhandledException (string name, string reason, string stack);

		[Static, Export ("optOutStatus")]//, Verify ("ObjC method massaged into setter property", "/Users/matt/Desktop/oppertunities/crittercism-xamarin/sdks/Crittercism_v4_3_3/CrittercismSDK/Crittercism.h", Line = 120)]
		bool OptOutStatus { set; }

		[Static, Export ("getOptOutStatus")]//, Verify ("ObjC method massaged into getter property", "/Users/matt/Desktop/oppertunities/crittercism-xamarin/sdks/Crittercism_v4_3_3/CrittercismSDK/Crittercism.h", Line = 124)]
		bool GetOptOutStatus { get; }

		[Static, Export ("maxOfflineCrashReports")]//, Verify ("ObjC method massaged into setter property", "/Users/matt/Desktop/oppertunities/crittercism-xamarin/sdks/Crittercism_v4_3_3/CrittercismSDK/Crittercism.h", Line = 136), Verify ("Backing getter method to ObjC property removed: maxOfflineCrashReports", "/Users/matt/Desktop/oppertunities/crittercism-xamarin/sdks/Crittercism_v4_3_3/CrittercismSDK/Crittercism.h", Line = 141)]
		uint MaxOfflineCrashReports { get; set; }

		[Static, Export ("getUserUUID")]//, Verify ("ObjC method massaged into getter property", "/Users/matt/Desktop/oppertunities/crittercism-xamarin/sdks/Crittercism_v4_3_3/CrittercismSDK/Crittercism.h", Line = 154)]
		string GetUserUUID { get; }

		[Static, Export ("username")]
		string Username { set; }

		[Static, Export ("setValue:forKey:")]
		void SetValue (string value, string key);

		[Static, Export ("delegate")]
		CrittercismDelegate Delegate { get; set; }

		[Static, Export ("didCrashOnLastLoad")]
		bool DidCrashOnLastLoad { get; }

	}


	public static class yack {

		public static void foo ()
		{
			Console.WriteLine( "myFunc");
		}//end yack

	}//end 

}

