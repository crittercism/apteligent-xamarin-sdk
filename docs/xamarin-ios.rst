=====
Xamarin-iOS SDK Documentation
=====

This topic describes how to use Crittercism with iOS apps.

Note
If this is your first time using Crittercism, go to the Crittercism Quickstart to get up and running quickly. Before you can install the Crittercism SDK, you must first sign up for your free Crittercism account, register your app (if needed), and download the Crittercism SDK for your app platform. Refer to the Release Notes for information about the version you downloaded.


Installing the Crittercism iOS SDK
----

Install the Crittercism SDK in your development environment.


#. Unzip the downloaded iOS SDK zip file.
#. Drag the CrittercismSDK folder into your XCode project.
#.Link with the SystemConfiguration framework.


Initializing Crittercism
----

Initialization is the process of modifying your app in order to communicate with Crittercism.

Import the Crittercism header in your application delegate’s implementation file.
#import "Crittercism.h"
Enable Crittercism in your AppDelegate’s application:didFinishLaunchingWithOptions: method.
- (BOOL)application:(UIApplication *)application didFinishLaunchingWithOptions:(NSDictionary *)launchOptions {
  [Crittercism enableWithAppID: @"531f7f9d0ee9483d3d000001"];
// other code for your app
  // ...
}

The code above is specific to the "[MyRegisteredAppName]" app. You can always find the Crittercism app ID for an app on the app settings page.
Note
Your crash reports will not contain symbol names and source code line references until you upload a dSYM to Crittercism. See the Symbolication section, below, for details.
Build your iOS app.
Your iOS app is now integrated with Crittercism. Additional features require adding more code to your project.

Configuring iOS Symbolication
----


For apps that have had their debug symbols removed, symbolication is the process of translating stack traces (by mapping symbols) into a human-readable form. Crittercism provides automatic, server-side symbolication, which requires that you provide your app’s symbol files.

To view your app’s symbol names and source code line number mappings with crash reports, do one of the following:

Use our API to automatically upload dSYM files either via jenkins, hudson, etc., or via a build script in XCode (see Uploading via a Build Script).
Compress the your app’s dSYM file and upload it on the app settings page (see Uploading dSYMs via a Command).
You can also view the dSYM file that has been uploaded (see Listing Uploaded dSYMs for an App).

Uploading via a Build Script

You can configure Xcode to automatically upload the dSYM (or symbols) file to Crittercism. Ensure that Xcode is configured to produce a Symbols file.

../_images/jumpstart_build_options.png
Log in to the Crittercism Portal and select an iOS application.
In the left pane, select App Settings.
In the right pane, select Upload dSYMs.
From the Upload via Build Script section, copy the 3 lines of text similar to the following:
APP_ID="0000000000000000000000000"
API_KEY="651234567890123ro3ch8lt2zi70eemgkakzv"
source ${SRCROOT}/CrittercismSDK/dsym_upload.sh
The dsym_upload.sh script is included with the iOS SDK (no additional download required).

Uploading dSYMs via a Command

Use the following command to upload a dSYM to the Crittercism server.

Syntax

curl "https://app.crittercism.com/api_beta/dsym/<app_id>" -F dsym=@"<path/to/dsym.zip>" -F key=<key>
Note
Specify the “@” symbol when using this command.
Arguments

Name	Description
app_id	Application ID.
path	Path to the dsym.zip file.
key	Key.
Returns

Code	Meaning
200	Success.
400	Problem with the dsym.zip file. The HTML response body describes the problem.
404	App not found or tokens incorrect.
Example

[Code Example that shows making the request and handling the return values.]
Listing Uploaded dSYMs for an App

Use the following command to get a list of dSYMs that have already been uploaded for a particular app.

Syntax

curl "https://app.crittercism.com/api_beta/dsyms/<app_id>" -F key=<key>
Arguments

Name	Description
app_id	Application ID.
key	Key.
Returns

List of dSYMs for that app in the following format.

{"dsyms": [<uuid>, <uuid>, ...]}
Example

[Code Example that shows making the request and handling the return values.]


Logging Breadcrumbs
----

Use the leaveBreadcrumb API to leave breadcrumbs in your code. A breadcrumb is a developer-defined text string (up to 140 characters) that allows developers to capture app run-time information, such as variable values, app states, progress through the code, user actions, time performance for user experience, and to flag events within callbacks (such as low memory warnings). For an introduction, see Breadcrumbs.

Sometimes a stack trace does not have enough information to quickly diagnose a crash. You can add debugging statements (see Breadcrumbs) to your code to capture the steps that an end-user took right before a crash. Some examples of using breadcrumbs include: logging screens viewed, recording button clicks, and changes in variable values.

If an app is using an in-house or third party-analytics service, developers can easily combine breadcrumbs with common event tracking or logging code.

[Crittercism leaveBreadcrumb:@"<breadcrumb>"];
For example, this is what you would see if you added breadcrumbs to your app:

../_images/crittercism-breadcrumbs.png
By default, breadcrumbs are flushed to disk immediately when written. This is by design because it provides an accurate record of everything that happened up until the point at which the app crashed.

If there are concerns about the performance costs of writing the file, instruct the library to perform all breadcrumb writes on a background thread.

Example:

[Crittercism setAsyncBreadcrumbMode:YES];



Logging Handled Exceptions
----


Use the logHandledException API to track error conditions in an app that do not necessarily cause the app to crash. Most common use cases for handled exceptions are for tracking places in your code where there already exists a try/catch, to test 3rd party SDKs, and critical areas in the code where you might already be adding assertions. Handled exceptions can also be used to track error events such as low memory warnings. For an introduction, see Handled Exceptions.

They’ll be grouped by stacktrace, much like crash reports, and you can view them in the “Handled Exceptions” area.

Here’s an example of how to log a handled exception in your app:

@try {
  [NSException raise:NSInvalidArgumentException
              format:@"Foo must not be nil"];
  // OR... call a method, or into a third party library that
  // you know might raise an exception
} @catch (NSException *exception) {
  // Pass it on to us!
  [Crittercism logHandledException:exception]
}
Note
We limit to sending five exceptions per minute.



Logging User Metadata
----

Use the metadata APIs (such as setMetadata and setUsername) to log user metadata in your code. Crittercism metadata is a set of arbitrary key/value pairs attached to a user’s session. Developers can use metadata for tracking demographic information about a user (email address, username, etc.) or various session parameters (level of a game, points, etc.). Crittercism automatically sets many pieces of system metadata when a crash occurs, including memory and disk use, operating system version, mobile carrier, and other data. For an introduction, see User Metadata.

You can associate a username with a specific device (see User Metadata). This will help you differentiate users on the portal. We recommend using a username string that you can tie back to your own database.

On the portal, the specified username will appear in the crash reporting tab.

Note
Enterprise developers can search for a user by username.
(Valid Input: String with length between 1 and 32)

[Crittercism setUsername:(NSString *)username];
You can associate arbitrary metadata with a user via the method below. The data will be viewable on the developer portal when viewing a user’s profile.

[Crittercism setValue:(NSString *)value forKey:(NSString *)key];



Other Tasks
----


This section describes other optional tasks.

Enhancing Crash Reporting

A crash is a run-time exception that occurs due to some unexpected event that terminates the user session. Crashes are not handled within a try/catch block. For an introduction, see Crash Reporting (Unhandled Exceptions).

If a run-time exception is raised outside of a @try/@catch block, it will generate a crash report that will be sent to Crittercism, along with some awesome diagnostics.

Try it out! Create a button that raises an exception:

- (IBAction)crashPressed:(id) sender {
    [NSException raise:NSInvalidArgumentException
                format:@"Foo must not be nil"];
}
Crash reports are sent the next time the app is loaded. Re-start the app and go to the crash summary page to view your crashes. Alternatively, you can view your crashes and app loads as they occur in real time on the live stats page.

Note
Disconnect the XCode debugger if you’re testing with the simulator, as it will prevent Crittercism from capturing the crash.
Handling Offline Crashes
If a user’s device does not have Internet connectivity, we cache any crashes that have occurred on the device until they can be sent to Crittercism. By default, we cache up to three (3) crashes on the device, but you can change this value using the setMaxOfflineCrashReports method:

[Crittercism setMaxOfflineCrashReports:(NSUInteger)max;];
If more than the maximum number of crashes occur, the oldest crash will be overwritten. Decreasing the value of this setting will not delete any offline crash reports. Unsent crash reports will be kept until they are successfully transmitted to Crittercism. Hence, there may be more than the maximum is stored on the device for a short period of time. You can specify a maximum of 10 offline crash reports.

Detecting that a Crash Occurred
In order to detect that your app crashed on the previous run, you can pass a delegate object (that conforms to the CrittercismDelegate protocol) to Crittercism during initialization:

@interface MyAwesomeViewController : UIViewController <CrittercismDelegate>
//...
#pragma mark CrittercismDelegate Method
- (void)crittercismDidCrashOnLastLoad {
    NSLog(@"App crashed the last time it was loaded");
}
//...
@end

[Crittercism enableWithAppID:@"MYAPPID"
              andDelegate:myViewController];
Configuring Service Monitoring

Whenever an app makes a network call, Crittercism monitors and captures certain information automatically. You can optionally configure filtering and location details. For an introduction, see Service Monitoring.

When Crittercism is enabled, the performance of HTTP traffic generated by NSURLConnection will be monitored. We support HTTP requests made specifically using the NSURLConnection API with a delegate object. We do not currently instrument calls to:

+[NSURLConnection sendAsynchronousRequest:queue:completionHandler]

or

+[NSURLConnection sendSynchronousRequest:returningResponse:error:]

For more information, refer to the Apple documentation.

Filtering Captured Data
While the actual contents of your requests are of course never inspected, we realize there may be certain URLs you don’t want showing up on the Crittercism Web Portal.

When enabling Crittercism, you can use a filters parameter to prevent sensitive URLs from being captured by the network instrumentation. To use this, pass in an NSArray of CRFilter objects that will be matched against URLs captured by the library.

Note
The filtering will take place off of your application’s main thread.
Default Behavior

Without any filters specified, Crittercism’s default behavior is to strip the query string off of all URLs. For example, given the URL:

https://api.compuglobalhypermeganet.com/store/purchase.asp?uname=homerjs
The URL reported to Crittercism’s servers would be:

https://api.compuglobalhypermeganet.com/store/purchase.asp
Types of Filters

You can use two modes of filtering:

Blacklisting - Completely discards matching URLs. They will not be reported to Crittercism.
“Preserve Query” filtering - Prevents the default behavior of stripping query parameters. Instead, for matching URLs, it preserves the query string.
Filtering Code Examples

Filters can be supplied when enabling Crittercism:

[Crittercism enableWithAppID:@"MYAPPID"
            andURLFilters:@[[CRFilter filterWithString:@"sensitiveURL"],
                        [CRFilter queryPreservingFilterWithString:@"lookupMovie"]]];
Additional filters can be added on the fly with the addFilter: method.

[Crittercism addFilter:(CRFilter *)filter];
Note
Network performance monitoring will only be enabled when running on iOS 5.0+.
Configuring Location
Crittercism service monitoring ties location information to network data. By default, location information is obtained through a reverse IP lookup. Starting with library version 4.1.1, you have the option of sending more accurate latitude and longitude information to our servers. You can inform Crittercism of the device’s most recent location by making the updateLocation: API call, as shown in the following example.

// Update location information
[Crittercism updateLocation:(CLLocation *)location];
Allowing Users to Opt Out of Crittercism

Crittercism provides a static opt-out status setting that disables all app reporting to Crittercism. Developers can implement code that asks users whether they want to opt out of Crittercism logging and reporting, and then call setOptOutStatus to change the status. Developers can also call requestOptOutStatus to determine the current status setting. For an introduction, see Opt Out of Crittercism.

Use the following API call to allow users to opt out of Crittercism reporting.

// Opt the user out
[Crittercism setOptOutStatus:YES];
When OptOutStatus is set to “YES”, there will be no information/requests sent from that user’s app. Typically, a developer would connect this API call to a checkbox in a settings menu.