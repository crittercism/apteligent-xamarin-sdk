using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;


using System.Runtime.InteropServices;


namespace Crittercism
{
	public enum CRFilterType : uint { ScrubQuery, Blacklist, PreserveQuery }

	/*
	[BaseType (typeof (NSObject))]
	public partial interface CRFilter {
		
		[Export ("filterType")]
		CRFilterType FilterType { get; }
		
		[Static, Export ("filterWithString:")]
		CRFilter FilterWithString (string matchToken);
		
		[Static, Export ("queryPreservingFilterWithString:")]
		CRFilter QueryPreservingFilterWithString (string matchToken);
		
		[Static, Export ("applyFilter:ToURL:")]
		string ApplyFilter (CRFilterType filterType, string url);
		
		[Export ("initWithString:")]
		IntPtr Constructor (string matchToken);
		
		[Export ("initWithString:andFilterType:")]
		IntPtr Constructor (string matchToken, CRFilterType filterType);
		
		[Export ("doesMatch:")]
		bool DoesMatch (string url);
		
		[Static, Export ("queryOnlyFilterWithString:")]
		CRFilter QueryOnlyFilterWithString (string matchToken);
	}
	*/

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
		//void EnableWithAppID (string appId, CrittercismDelegate critterDelegate, [Verify ("NSArray may be reliably typed, check the documentation", "/Users/matt/Desktop/oppertunities/crittercism-xamarin/sdks/Crittercism_v4_3_3/CrittercismSDK/Crittercism.h", Line = 58)] NSObject [] filters);

		[Static, Export ("enableWithAppID:andURLFilters:")]
		void EnableWithAppID (string appId, NSObject [] filters);
		//void EnableWithAppID (string appId, [Verify ("NSArray may be reliably typed, check the documentation", "/Users/matt/Desktop/oppertunities/crittercism-xamarin/sdks/Crittercism_v4_3_3/CrittercismSDK/Crittercism.h", Line = 62)] NSObject [] filters);

		[Static, Export ("enableWithAppID:andDelegate:andURLFilters:disableInstrumentation:")]
		void EnableWithAppID (string appId, CrittercismDelegate critterDelegate, NSObject [] filters, bool disableInstrumentation);
		//void EnableWithAppID (string appId, CrittercismDelegate critterDelegate, [Verify ("NSArray may be reliably typed, check the documentation", "/Users/matt/Desktop/oppertunities/crittercism-xamarin/sdks/Crittercism_v4_3_3/CrittercismSDK/Crittercism.h", Line = 66)] NSObject [] filters, bool disableInstrumentation);

		//[Static, Export ("addFilter:")]
		//void AddFilter (CRFilter filter);

		[Static, Export ("leaveBreadcrumb:")]
		void LeaveBreadcrumb (string breadcrumb);

		[Static, Export ("asyncBreadcrumbMode")]//, Verify ("ObjC method massaged into setter property", "/Users/matt/Desktop/oppertunities/crittercism-xamarin/sdks/Crittercism_v4_3_3/CrittercismSDK/Crittercism.h", Line = 98)]
		bool AsyncBreadcrumbMode { set; }

		[Static, Export ("updateLocation:")]
		void UpdateLocation (CLLocation location);

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

		[Static, Export ("username")]//, Verify ("ObjC method massaged into setter property", "/Users/matt/Desktop/oppertunities/crittercism-xamarin/sdks/Crittercism_v4_3_3/CrittercismSDK/Crittercism.h", Line = 159)]
		string Username { set; }

		[Static, Export ("setValue:forKey:")]
		void SetValue (string value, string key);

		[Static, Export ("delegate")]//, Verify ("ObjC method massaged into getter property", "/Users/matt/Desktop/oppertunities/crittercism-xamarin/sdks/Crittercism_v4_3_3/CrittercismSDK/Crittercism.h", Line = 167), Verify ("Backing setter method to ObjC property removed: setDelegate:", "/Users/matt/Desktop/oppertunities/crittercism-xamarin/sdks/Crittercism_v4_3_3/CrittercismSDK/Crittercism.h", Line = 169)]
		CrittercismDelegate Delegate { get; set; }

		[Static, Export ("didCrashOnLastLoad")]//, Verify ("ObjC method massaged into getter property", "/Users/matt/Desktop/oppertunities/crittercism-xamarin/sdks/Crittercism_v4_3_3/CrittercismSDK/Crittercism.h", Line = 173)]
		bool DidCrashOnLastLoad { get; }

	}

	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_libraries
	//
}

