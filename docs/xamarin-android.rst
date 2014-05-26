Android SDK Documentation

This topic describes how to use Crittercism with Android apps (including Android NDK apps).

Note
If this is your first time using Crittercism, go to the Crittercism Quickstart to get up and running quickly. Before you can install the Crittercism SDK, you must first sign up for your free Crittercism account, register your app (if needed), and download the Crittercism SDK for your app platform. Refer to the Release Notes for information about the version you downloaded.
Installing the Crittercism Android SDK

Install the Crittercism SDK in your development environment.

Create a folder called libs in your project. Copy the Crittercism JAR file to this libs folder. If you are compiling with Eclipse, you may need to refresh your project.
Add the Crittercism JAR to your project. Right click your project, click Properties, select Java Build Path, click Add External Jar, and then add the Crittercism JAR file.
Copy and paste the following code snippet into your project’s AndroidManifest.xml file.
Note
Verify that you have the INTERNET permission in between the <manifest> ... </manifest> tags.
<uses-permission android:name="android.permission.INTERNET"/>
For more granular data, you can optionally add the following two permissions into your project’s AndroidManifest.xml file.
Using the optional READ_LOGS permission provides Crittercism access to device Logcat information for Android OS 2.2 to 4.0. After 4.0, this permission is provided free at the app scope, not including system logs.
<uses-permission android:name="android.permission.READ_LOGS"/>
Using the optional ACCESS_NETWORK_STATE permission provides Crittercism access to a user’s network state, such as whether the user was on Wi-Fi or carrier. This is for both error and service monitoring data.
<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE"/>
Using the optional GET_TASKS permission provides Crittercism access to information about the last two activities running (shown in Crash diagnostics), which allows you to see which activity was active when a crash occurs.
<uses-permission android:name="android.permission.GET_TASKS"/>
For more information on these permissions, refer to the Android Manifest documentation

Initializing Crittercism

Initialization is the process of modifying your app in order to communicate with Crittercism.

Add this import and init only once in your code. In the top of your main activity (the same activity as your android.intent.action.MAIN intent filter), add the following import:
import com.crittercism.app.Crittercism;
Initialize Crittercism on the main thread at the beginning of your onCreate activity.
Crittercism.initialize(getApplicationContext(), "CRITTERCISM_APP_ID");
Build your Android app.
Your Android app is now integrated with Crittercism. Additional features require adding more code to your project.

Configuring Proguard Symbolication

For apps that have had their debug symbols removed, symbolication is the process of translating stack traces (by mapping symbols) into a human-readable form. Crittercism provides automatic, server-side symbolication, which requires that you provide your app’s symbol files.

Note
Follow the instructions in this section only if your app obfuscates with Android Proguard. Otherwise, skip this section.
For Android applications, developers have the option to obfuscate their function names using the ProGuard tool in order to reduce app size and to prevent others from reverse engineering the app source. In order to replace the obfuscated name with a human-readable name, developers use a Proguard mapping file.

Setting Up ProGuard

To build a project with Crittercism, place the Crittercism JAR in the libs/ directory of your project.
Add the following lines to your project’s proguard.cfg file:
-keep public class com.crittercism.**
-keepclassmembers public class com.crittercism.*
{
    *;
}
To get line number information, make sure that you keep the file names and line numbers in your ProGuard .cfg settings file.
-keepattributes SourceFile, LineNumberTable
This information will be visible in all stacktraces, however - even those that are not symbolicated.

Uploading the mapping.txt File

To have your crashes automatically symbolized, you must upload a mapping.txt file on your App Settings page.

Each mapping.txt file you upload is associated with a version of your app. We symbolize crashes for only one version with each mapping.txt file.

Note
Be careful to upload the right file for your version! If you upload the wrong file, you might get incorrect stacktraces. If you accidentally upload the wrong mapping.txt for a version, simply delete the file and upload it again.
Use the following command to upload a Proguard mapping file to the Crittercism server.

Syntax

curl "https://app.crittercism.com/api_beta/proguard/<app_id>" -F proguard=@"<path/to/proguard-mapping.txt>" -F app_version="app-version-name" -F key=<key>
Note
Specify the “@” symbol when using this command.
Arguments

Name	Description
app_id	Application ID.
path	Path to the proguard-mapping.txt file.
app-version-name	Name of the app version.
key	Key.
Returns

Code	Meaning
200	Success.
400	Problem with the specified proguard file. The HTML response body describes the problem.
404	App not found or tokens incorrect.
Note
If you set a customized app version name in the CrittercismConfig instance, you should use that string and not the manifest string in app-version-name. Also, if you choose to include the app version code in the app version, that should also be included in app-version-name.
Adding a Command to the Build File
You can insert an additional step in your build file to execute a command based on the following example. Consult the Crittercism API docs for more information.

curl "https://app.crittercism.com/api_beta/proguard/<app_id>" -F proguard=@"<path/to/proguard-mapping.txt>" -F
app_version="app-version-name" -F key=<key>
Crittercism provides a plugin for Jenkins (a popular build system), which automatically uploads Symbol files created by Jenkins.

Note
At this point, you have enabled Crittercism to receive Application Performance Information from your application, and have set up your build environment to automatically provide Crittercism with your symbol files.
Configuring Android NDK Symbolication

For apps that have had their debug symbols removed, symbolication is the process of translating stack traces (by mapping symbols) into a human-readable form. Crittercism provides automatic, server-side symbolication, which requires that you provide your app’s symbol files.

Note
Follow the instructions in this section only if you have an Android NDK app in which NDK crash reporting is enabled (using setNdkCrashReportingEnabled(boolean)). Otherwise, skip this section.
For Android NDK applications that use NDK crash reporting, developers can upload a symbols (.so) file that contains debug characters in order to convert stack traces into more-readable text.

Uploading Symbols Using the Console

You can upload the symbols using the console/terminal. Refer to the app’s settings page under the Upload NDK Symbols tab in your App Settings.

Change to your root application directory.
Zip up the obj directory in your Android project.
Drag that zip archive into the drop box (located under the Upload NDK Symbols tab in your App Settings) for uploading NDK symbols. It will report back either 200 OK and tell you for which library you just uploaded symbols, or it will report an error.
Go to a crash report and click Add to Symbolication Queue.
Once you complete these steps, you should be able to view your symbolicated native crashes. Thereafter, your crashes from that build will be symbolicated automatically.

Uploading Symbols Using a Command

You can also use the following command to upload an NDK symbol file to the Crittercism server.

Syntax

curl "https://app.crittercism.com/api_beta/ndksym/<app_id>" -F ndksym=@"<path/to/ndksym.so.zip>" -F key=<key>
Note
Specify the “@” symbol when using this command.
Arguments

Name	Description
app_id	Application ID.
path	Path to the ndksym.so.zip file.
key	Key.
Returns

Code	Meaning
200	Success.
400	Problem with the specified NDK symbol file. The HTML response body describes the problem with the file.
404	App not found or tokens incorrect.
Logging Breadcrumbs

Use the leaveBreadcrumb API to leave breadcrumbs in your code. A breadcrumb is a developer-defined text string (up to 140 characters) that allows developers to capture app run-time information, such as variable values, app states, progress through the code, user actions, time performance for user experience, and to flag events within callbacks (such as low memory warnings). For an introduction, see Breadcrumbs.

By placing breadcrumbs in your code, you can get a playback of events in the run-up to a crash. With breadcrumbs, you can see which buttons a user pressed, which activities were active, and see what variables were changed right before a crash occurred. For each session, the Android library automatically stores a session_start breadcrumb to mark the beginning of a user session, and the most recent 49 breadcrumbs that were left before a crash.

To leave a breadcrumb, simply insert the following API call at points of interest in your code after initializing Crittercism.

// Did the user get here before crashing?
String breadcrumb = "My Breadcrumb";
Crittercism.leaveBreadcrumb(breadcrumb);
Logging Handled Exceptions

Use the logHandledException API to track error conditions in an app that do not necessarily cause the app to crash. Most common use cases for handled exceptions are for tracking places in your code where there already exists a try/catch, to test 3rd party SDKs, and critical areas in the code where you might already be adding assertions. Handled exceptions can also be used to track error events such as low memory warnings. For an introduction, see Handled Exceptions.

They’ll be grouped much like your normal uncaught exceptions, and you can view them in the “Handled Exceptions” area.

Here’s an example of how to log a handled exception in your app:

try {
    throw new Exception("Exception Reason");
} catch (Exception exception) {
    Crittercism.logHandledException(exception);
}
Note
We limit logging handled exceptions to once per minute. If you’ve logged an exception within the last minute, we buffer the last five exceptions and send those after a minute has passed.
Logging User Metadata

Use the metadata APIs (such as setMetadata and setUsername) to log user metadata in your code. Crittercism metadata is a set of arbitrary key/value pairs attached to a user’s session. Developers can use metadata for tracking demographic information about a user (email address, username, etc.) or various session parameters (level of a game, points, etc.). Crittercism automatically sets many pieces of system metadata when a crash occurs, including memory and disk use, operating system version, mobile carrier, and other data. For an introduction, see User Metadata.

Adding a Username

You can attach a username to each user. This data will help you differentiate users in the portal. We recommend setting a username to a user id that you can tie back to your own database. On the portal, the specified username will appear in the crash reporting tab. Enterprise developers can search for a user by username. This is especially useful for customers that want to tie crash data with a customer support system.

Username (Valid Inputs: Strings with length between 1 and 32)

Crittercism.setUsername("custom-username-here");
Adding Arbitrary User Metadata

You can also attach an arbitrary amount of metadata to each user using the following method. The data will be stored in a dictionary and displayed on the developer portal when viewing a user profile.

// instantiate metadata json object
JSONObject metadata = new JSONObject();
// add arbitrary metadata
metadata.put("user_id", 123);
metadata.put("name", "John Doe");
// send metadata to crittercism (asynchronously)
Crittercism.setMetadata(metadata);
Other Tasks

This section describes other optional tasks.

Enhancing Crash Reporting

A crash is a run-time exception that occurs due to some unexpected event that terminates the user session. Crashes are not handled within a try/catch block. For an introduction, see Crash Reporting (Unhandled Exceptions).

In order to find out whether an app crashed in the previous session, make an asynchronous request in the following fashion:

import com.crittercism.app.Crittercism;
import com.crittercism.app.CritterCallback;
import com.crittercism.app.CritterUserData;
import com.crittercism.app.CritterUserDataRequest;

import android.os.Bundle;

@Override protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    Crittercism.initialize(getApplicationContext(),
        "<CRITTERCISM_APP_ID>", crittercismConfig);
    someMethodInMyCode();
}

public void someMethodInMyCode() {
    // Instantiate callback object.
    CritterCallback cb = new CritterCallback() {
        // CritterCallback is an interface that requires you to implement
        // onCritterDataReceived(CritterUserData).
        @Override public void onCritterDataReceived(CritterUserData userData) {
            boolean crashedOnLastLoad = userData.crashedOnLastLoad();
            // ...do something with crashedOnLastLoad
        }
    };

// Instantiate data request object, and specify that it should include
// information on whether the previous app session crashed.

CritterUserDataRequest request = new CritterUserDataRequest(cb)
                                   .requestDidCrashOnLastLoad();

// Fire off the request.
request.makeRequest();
}
Note
Remember to invoke requestDidCrashOnLastLoad(). Otherwise, a warning will appear in your logs and a value of false will be returned.
Configuring Service Monitoring

Whenever an app makes a network call, Crittercism monitors and captures certain information automatically. You can optionally configure filtering and location details. For an introduction, see Service Monitoring.

When Crittercism is enabled, the performance of HTTP traffic generated by either java.net.HttpURLConnection or org.apache.http.impl.client.DefaultHttpClient will be monitored. No action is needed in order to turn on Network Performance Monitoring. Simply initialize Crittercism as normal.

Filtering Captured Data
While the actual contents of your requests are of course never inspected, we realize there may be certain URLs you don’t want showing up on the Crittercism Web Portal. By default, all URLs are stripped of query parameters before being sent to Crittercism. For example the URL www.yoururl.com/login?secret=foobar would be reported as www.yoururl.com/login. To learn how to avoid this behavior, see the section below on Keeping Query Parameters for Specific URLs.

Blacklisting URLs

URL blacklisting can be used to prevent sensitive URLs from being captured by the network instrumentation. Use the CrittercismConfiguration object to setURLBlacklistPatterns() for the URLs that should not be monitored by Crittercism. This configuration option must be set at Crittercism initialization time.

The setURLBlacklistPatterns() method takes a List of String objects that will be matched against URLs captured by the library. If any of the input String are contained in a URL, the URL will not be reported to Crittercism.

Example:

List<String> urlBlacklistPatterns = new LinkedList<String>();
urlBlacklistPatterns.add("blacklisted_url");

CrittercismConfig config = new CrittercismConfig();
config.setURLBlacklistPatterns(urlBlacklistPatterns);

Crittercism.initialize(getApplicationContext(), "<CRITTERCISM_APP_ID>", config);
Keeping Query Parameters for Specific URLs

As stated above, URLs will be stripped of query parameters before being sent to Crittercism. However, there may be circumstances where it is desirable to preserve query parameters for a particular URL. To prevent query parameter stripping for specific URLs, you may supply a list of URL patterns at Crittercism initialization time using a CrittercismConfiguration object. Set the list of patterns, by calling setPreserveQueryStringPatterns(List<String> urlPatterns).

The list of patterns supplied to setPreserveQueryStringPatterns() are matched against URLs by checking if the pattern is a substring of a URL.

Example:

List<String> preserveQueryPatterns = new LinkedList<String>();
preserveQueryPatterns.add("mysite.com");

CrittercismConfig config = new CrittercismConfig();
config.setPreserveQueryStringPatterns(preserveQueryPatterns);

Crittercism.initialize(getApplicationContext(), "<CRITTERCISM_APP_ID>", config);
Updating the Location
Crittercism Performance Monitoring now ties location information to network data. By default, location information is obtained through a reverse IP lookup. Starting with library version 4.2.0, you have the option of updating location information with data given by android.location.LocationManager.NETWORK_PROVIDER or android.location.LocationManager.GPS_PROVIDER. This allows more accurate data to be sent to the server. As explained in the Android Developer Guide, in order to receive location updates from the network or GPS provider, your AndroidManifest.xml file must include either the ACCESS_COARSE_LOCATION or ACCESS_FINE_LOCATION permission.

In order to update location information, use the Crittercism.updateLocation(Location) call, as demonstrated in the following code sample.

import com.crittercism.app.Crittercism;

import android.content.Context;
import android.os.Bundle;

import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;

@Override protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    Crittercism.initialize(getApplicationContext(), "<CRITTERCISM_APP_ID>");
    startLocationTracking();
}

private void startLocationTracking() {
    // Based on code sample in the Android Developer Guide: Location Strategies.
    // See http://developer.android.com/guide/topics/location/strategies.html for
    // more info.

    LocationManager locationManager = (LocationManager) getSystemService(Context.LOCATION_SERVICE);

    LocationListener locationListener = new LocationListener() {
        public void onLocationChanged(Location location) {
            // Update most recent location in Crittercism.
            Crittercism.updateLocation(location);
        }

        public void onStatusChanged(String provider, int status, Bundle extras) {
            // Do something.
        }

        public void onProviderEnabled(String provider) {
            // Do something.
        }

        public void onProviderDisabled(String provider) {
            // Do something.
        }
    };

    // Request location updates through the GPS tracker. You can also use LocationManager.NETWORK_PROVIDER
    // to get location information from cell towers and Wifi.
    // NOTE: Don't forget to include either the ACCESS_COARSE_LOCATION or ACCESS_FINE_LOCATION permission
    // in your AndroidManifest.xml file!!)
    locationManager.requestLocationUpdates(LocationManager.GPS_PROVIDER, 0, 0, locationListener);
}
Allowing Users to Opt Out of Crittercism

Crittercism provides a static opt-out status setting that disables all app reporting to Crittercism. Developers can implement code that asks users whether they want to opt out of Crittercism logging and reporting, and then call setOptOutStatus to change the status. Developers can also call requestOptOutStatus to determine the current status setting. For an introduction, see Opt Out of Crittercism.

To opt out users, use the following API call:

boolean optOutStatus = true;
Crittercism.setOptOutStatus(optOutStatus);
You can also retrieve a current user’s opt-out status to determine whether a user has opted out of Crittercism. Make an asynchronous request in the following fashion:

import com.crittercism.app.Crittercism;
import com.crittercism.app.CritterCallback;
import com.crittercism.app.CritterUserData;
import com.crittercism.app.CritterUserDataRequest;

import android.os.Bundle;

@Override protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    Crittercism.initialize(getApplicationContext(),
        "<CRITTERCISM_APP_ID>", crittercismConfig);
    someMethodInMyCode();
}

public void someMethodInMyCode() {
    // Instantiate callback object.
    CritterCallback cb = new CritterCallback() {
        // CritterCallback is an interface that requires you to implement
        // onCritterDataReceived(CritterUserData).
        @Override public void onCritterDataReceived(CritterUserData userData) {
            boolean isOptedOut = userData.isOptedOut();
            // ...do something with isOptedOut
        }
    };

    // Instantiate data request object, and specify that it should include
    // information on whether the has opted out.
    CritterUserDataRequest request = new CritterUserDataRequest(cb)
                                            .requestOptOutStatus();

    // Fire off the request.
    request.makeRequest();
}
Rate My App

Note
Supported as of library version 3.2.0.
Note
This feature only works on API levels 5 and up.
If you have enabled Rate App Alert in your App Settings, the Crittercism library will receive and handle settings for Rate My App alerts as specified in the server. In order to enable Rate My App alerts and have them behave according to the server settings, two steps are required:

Find out if a Rate My App alert dialog should be shown.
Create the alert dialog and show it.
Note
Supported as of library version 3.2.0.
Important
Because of the complications with properly handling UI elements from a library, the Crittercism library does not actually show the AlertDialog. The developer is responsible for showing the dialog, and dismissing it during onPause() events.
In order to do the first step (find out if a dialog should be shown), make an asynchronous request in the following fashion after initializing:

import com.crittercism.app.Crittercism;
import com.crittercism.app.CritterCallback;
import com.crittercism.app.CritterUserData;
import com.crittercism.app.CritterUserDataRequest;

import android.os.Bundle;

@Override protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    Crittercism.initialize(getApplicationContext(),
        "<CRITTERCISM_APP_ID>", crittercismConfig);
    someMethodInMyCode();
}

public void someMethodInMyCode() {
    // Instantiate callback object.
    CritterCallback cb = new CritterCallback() {
        // CritterCallback is an interface that requires you to implement
        // onCritterDataReceived(CritterUserData).
        @Override public void onCritterDataReceived(CritterUserData userData) {
            boolean shouldShowRateMyAppAlert = userData.shouldShowRateMyAppAlert();
            String title = userData.getRateMyAppTitle();
            String message = userData.getRateMyAppMessage();

            if (shouldShowRateMyAppAlert) {
                // ...send title and message to some code that will generate the
                // AlertDialog.
            }
        }
    };

    // Instantiate data request object, and specify that it should include
    // information for Rate My App.
    CritterUserDataRequest request = new CritterUserDataRequest(cb)
                                            .requestRateMyAppInfo();

    // Fire off the request.
    request.makeRequest();
}
Do not forget to invoke requestRateMyAppInfo(). Otherwise, several warnings will appear in your logs, CritterUserData.shouldShowRateMyAppAlert() will return false, and CritterUserData.getRateMyAppTitle() and CritterUserData.getRateMyAppMessage() will return null.

Once you have established that an AlertDialog should be displayed, the Crittercism library offers two different methods for generating the AlertDialog in something of a Goldilocks Approach.

Method 1 (The Easiest)
The Crittercism.generateRateMyAppAlertDialog(Context) will create and return an AlertDialog instance if called properly, and null otherwise (for situations in which this API call returns null, please refer to the bullet points below the code sample). You can then send a message to a Handler object to display the AlertDialog.

import com.crittercism.app.Crittercism;
import com.crittercism.app.CritterCallback;
import com.crittercism.app.CritterUserData;
import com.crittercism.app.CritterUserDataRequest;
import com.crittercism.app.Crittercism;

import android.app.AlertDialog;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;

static final Handler myHandler = new AlertDialogHandler();

private static class AlertDialogHandler extends Handler {
    private final static int ALERT_DIALOG_WHAT = 1;
    private AlertDialog ad = null;

public void setAlertDialog(AlertDialog ad) {
     this.ad = ad;
}

public void dismissAlertDialog() {
    ad.dismiss();
}

@Override public void handleMessage(Message msg) {
    switch (msg.what) {
        case ALERT_DIALOG_WHAT:
            // Ensure that Crittercism.generateRateMyAppAlertDialog(Context)
            // did not return null.
            if (ad != null) {
                ad.show();
            }
            break;
        default:
            break;
       }
   }
}

@Override protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    Crittercism.initialize(getApplicationContext(),
        "<CRITTERCISM_APP_ID>", crittercismConfig);
    someMethodInMyCode();
}

@Override protected void onPause() {
    // Prevent window leaking by dismissing dialog.
    ((AlertDialogHandler)myHandler).dismissAlertDialog();
    super.onPause();
}

public void someMethodInMyCode() {
    // Instantiate callback object.
    CritterCallback cb = new CritterCallback() {
        // CritterCallback is an interface that requires you to implement
        // onCritterDataReceived(CritterUserData).
        @Override public void onCritterDataReceived(CritterUserData userData) {
            boolean shouldShowRateMyAppAlert = userData.shouldShowRateMyAppAlert();
            if (shouldShowRateMyAppAlert) {
                // Initialize the thread as a looper.
                Looper.prepare();

                // Generate the alert dialog.
                // IMPORTANT: you must pass in the *Activity* instance to
                // generateRateMyAppAlertDialog(Context). If you attempt to pass
                // in getApplicationContext(), the AlertDialog instance will not
                // be created properly and the method will return null.
                ((AlertDialogHandler)myHandler).setAlertDialog(
                    Crittercism.generateRateMyAppAlertDialog(MyActivity.this));
                myHandler.dispatchMessage(Message.obtain(myHandler,
                    AlertDialogHandler.ALERT_DIALOG_WHAT));

                Looper.loop();
                Looper.myLooper().quit();
            }
        }
    };

    // Instantiate data request object, and specify that it should include
    // information for Rate My App.
    CritterUserDataRequest request = new CritterUserDataRequest(cb)
                                            .requestRateMyAppInfo();

    // Fire off the request.
    request.makeRequest();
}
Note
Important: This method will return null in the following cases:
The device is not running API Level 5 or higher.
Rate App Alert is not enabled on the server.
The calling thread is not initialized as a looper (by calling Looper.prepare()).
A valid Activity instance is not provided for activityContext.
The user has opted out of Crittercism.
A valid vending string is not found for the application package (e.g. "com.amazon.venezia"), AND CrittercismConfig.getRateMyAppTestTarget() is null.
The library will print the appropriate warnings in the logs if any of these conditions is met. Before showing the AlertDialog, ALWAYS ensure it is not null!!!

Method 2 (Also Pretty Easy)
The Crittercism.generateRateMyAppAlertDialog(Context, String, String) will create and return an AlertDialog instance if called properly, and null otherwise (for situations in which this API call returns null, please refer to the bullet points below the code sample). You can then send a message to a Handler object to display the AlertDialog. This method could be useful for issues surrounding internationalization.

import com.crittercism.app.Crittercism;
import com.crittercism.app.CritterCallback;
import com.crittercism.app.CritterUserData;
import com.crittercism.app.CritterUserDataRequest;
import com.crittercism.app.Crittercism;

import android.app.AlertDialog;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;

static final Handler myHandler = new AlertDialogHandler();

private static class AlertDialogHandler extends Handler {
    private final static int ALERT_DIALOG_WHAT = 1;
    private AlertDialog ad = null;

    public void setAlertDialog(AlertDialog ad) {
        this.ad = ad;
    }

    public void dismissAlertDialog() {
        ad.dismiss();
    }

    @Override public void handleMessage(Message msg) {
        switch (msg.what) {
            case ALERT_DIALOG_WHAT:
                // Ensure that Crittercism.generateRateMyAppAlertDialog(Context, String, String)
                // did not return null.
                if (ad != null) {
                    ad.show();
                }
                break;
            default:
               break;
           }
       }

}

@Override protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    Crittercism.initialize(getApplicationContext(),
        "<CRITTERCISM_APP_ID>", crittercismConfig);
    someMethodInMyCode();
}

@Override protected void onPause() {
    // Prevent window leaking by dismissing dialog.
    ((AlertDialogHandler)myHandler).dismissAlertDialog();
    super.onPause();
}

public void someMethodInMyCode() {
    // Instantiate callback object.
    CritterCallback cb = new CritterCallback() {
        // CritterCallback is an interface that requires you to implement
        // onCritterDataReceived(CritterUserData).
        @Override public void onCritterDataReceived(CritterUserData userData) {
            boolean shouldShowRateMyAppAlert = userData.shouldShowRateMyAppAlert();
            if (shouldShowRateMyAppAlert) {
                String title = userData.getRateMyAppTitle();
                String message = userData.getRateMyAppMessage();
                // Initialize the thread as a looper.
                Looper.prepare();

                // Generate the alert dialog.
                // IMPORTANT: you must pass in the *Activity* instance to
                // generateRateMyAppAlertDialog(Context, String, String). If you
                // attempt to pass in getApplicationContext(), the AlertDialog
                // instance will not be created properly and the method will return
                // null.
                ((AlertDialogHandler)myHandler).setAlertDialog(
                    Crittercism.generateRateMyAppAlertDialog(MyActivity.this,
                    title, message));
                myHandler.dispatchMessage(Message.obtain(myHandler,
                AlertDialogHandler.ALERT_DIALOG_WHAT));

                Looper.loop();
                Looper.myLooper().quit();
            }
        }
    };

    // Instantiate data request object, and specify that it should include
    // information for Rate My App.
    CritterUserDataRequest request = new CritterUserDataRequest(cb)
                                         .requestRateMyAppInfo();

    // Fire off the request.
    request.makeRequest();
}
Note
Important: This method will return null in the following cases:
The device is not running API Level 5 or higher.
A null message or zero-length message is passed in.
The calling thread is not initialized as a looper (by calling Looper.prepare()).
A valid Activity instance is not provided for activityContext.
The user has opted out of Crittercism.
A valid vending string is not found for the application package (e.g. "com.amazon.venezia"), AND CrittercismConfig.getRateMyAppTestTarget() is null.
The library will print the appropriate warnings in the logs if any of these conditions is met. Before showing the AlertDialog, ALWAYS ensure it is not null!!!
Callbacks and User Data Reports

To get information about the user’s opt out status, the user UUID, and whether the app crashed on the last app load, and to get any other data that potentially requires asynchronous disk reads or network IO, the library provides a callback interface called CritterCallback. The developer instantiates a CritterUserDataRequest object with a CritterCallback instance, and then specifies the types of data to be included in the CritterUserData report that is returned.

import com.crittercism.app.Crittercism;
import com.crittercism.app.CritterCallback;
import com.crittercism.app.CritterUserData;
import com.crittercism.app.CritterUserDataRequest;

import android.os.Bundle;

@Override protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    Crittercism.initialize(getApplicationContext(),
        "<CRITTERCISM_APP_ID>", crittercismConfig);
    someMethodInMyCode();
}

public void someMethodInMyCode() {
    /* EXAMPLE 1 */
    // Instantiate a CritterCallback object.
    CritterCallback cb1 = new CritterCallback() {
        // CritterCallback is an interface that requires you to implement
        // onCritterDataReceived(CritterUserData).
        @Override public void onCritterDataReceived(CritterUserData userData) {
            // ...do something with userData
        }
    };

    // Instantiate a CritterUserDataRequest object.
    CritterUserDataRequest req1 = new CritterUserDataRequest(cb1);

    // Request information on whether previous session crashed.
    req1.requestDidCrashOnLastLoad();

    // Fire off request.
    req1.makeRequest();


    /* EXAMPLE 2 */
    // Instantiate a CritterCallback object.
    CritterCallback cb2 = new CritterCallback() {
        // CritterCallback is an interface that requires you to implement
        // onCritterDataReceived(CritterUserData).
        @Override public void onCritterDataReceived(CritterUserData userData) {
            // ...do something with userData
        }
    };

    // The various request* methods return the CritterUserDataRequest instance,
    // so you can chain their calls.  For example, the following request will
    // include information on user UUID, Rate My App settings, and last session
    // crashing.
    CritterUserDataRequest req2 = new CritterUserDataRequest(cb2)
                                        .requestDidCrashOnLastLoad()
                                        .requestUserUUID()
                                        .requestRateMyAppInfo();

    // Fire off request.
    req2.makeRequest();
}
The CrittercismUserData object supports the following API calls:

API Call	Description
crashedOnLastLoad()	Returns true if app crashed in previous session. For proper functionality, user must not be opted out and the developer must invoke requestDidCrashOnLastLoad() for the appropriate CritterUserDataRequestObject. Otherwise, returns false.
isOptedOut()	Returns true if the user has opted out of Crittercism. Otherwise, returns false.
getUserUUID()	Returns the unique user UUID generated by the Crittercism library. For proper functionality, user must not be opted out and the developer must invoke requestUserUUID() for the appropriate CritterUserDataRequestObject. Otherwise, returns null.
getRateMyAppMessage()	Returns the server-specified Rate My App message if the dialog should be displayed. For proper functionality, user must not be opted out and the developer must invoke requestRateMyAppInfo() for the appropriate CritterUserDataRequestObject. Otherwise, returns null.
getRateMyAppTitle()	Returns the server-specified Rate My App title if the dialog should be displayed. For proper functionality, user must not be opted out and the developer must invoke requestRateMyAppInfo() for the appropriate CritterUserDataRequestObject. Otherwise, returns null.
shouldShowRateMyAppAlert()	Returns true if Rate My App alert dialog should be displayed. For proper functionality, user must not be opted out and the developer must invoke requestRateMyAppInfo() for the appropriate CritterUserDataRequestObject. Otherwise, returns false.
Setting Advanced Crittercism Options

Customizing the Version Name (Optional)
Note
Supported as of library version 3.0.3.
This configuration option allows you to customize the app version diagnostic that is reported to Crittercism. It will allow you to filter crashes, handled exceptions, app loads, and service monitoring data by a custom app version, and this version will appear in the Proguard mapping upload page of the website.

For library versions 3.1.4 and above, use an instance of CrittercismConfig as shown in the following code example:

import com.crittercism.app.Crittercism;
import com.crittercism.app.CrittercismConfig;

import android.os.Bundle;

@Override protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);

    // create the CrittercismConfig instance.
    CrittercismConfig config = new CrittercismConfig();
    String myCustomVersionName = "My Custom Version Name";
    // set the custom version name.
    config.setCustomVersionName(myCustomVersionName);
    // initialize.
    Crittercism.initialize(getApplicationContext(),
        "<CRITTERCISM_APP_ID>", crittercismConfig);
}
Include Version Code
Note
Supported as of library version 3.0.11.
This configuration option allows you to include the version code from the manifest file in your app version name. On the website the version will then have the format VERSIONNAME-VERSIONCODE. By default, this configuration setting is false.

For library versions 3.1.4 and above, use an instance of CrittercismConfig as demonstrated in the following code:

import com.crittercism.app.Crittercism;
import com.crittercism.app.CrittercismConfig;

import android.os.Bundle;

@Override protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);

    // Create the CrittercismConfig instance.
    CrittercismConfig config = new CrittercismConfig();
    boolean shouldIncludeVersionCode = true;
    // Set the custom version name.
    config.setVersionCodeToBeIncludedInVersionString(shouldIncludeVersionCode);
    // Initialize.
    Crittercism.initialize(getApplicationContext(),
        "<CRITTERCISM_APP_ID>", crittercismConfig);
}
Include Logcat
Including system log data (Logcat) can be helpful in debugging a crash. Crittercism does not require access to logcat to work. If you are using library version 3.0 and above, you can collect logcat information for API Levels 16 and higher (Jelly Bean and up).

For library versions 3.1.4 and above, use an instance of CrittercismConfig as demonstrated in the following code:

import com.crittercism.app.Crittercism;
import com.crittercism.app.CrittercismConfig;

import android.os.Bundle;

@Override protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);

    // Create the CrittercismConfig instance.
    CrittercismConfig config = new CrittercismConfig();
    boolean shouldCollectLogcat = true;
    // Enable logcat collection.
    config.setLogcatReportingEnabled(shouldCollectLogcat);
    // Initialize.
    Crittercism.initialize(getApplicationContext(),
        "<CRITTERCISM_APP_ID>", config);
}
Send App Load Data
Note
Supported as of library version 3.0.0.
The Crittercism SDK reports an app load when Crittercism is initialized. In order to send app load data at a later time, you will need to set the appropriate configuration option to true. Once the parameter to delay sending app load data is set, you can send app load information at any time by calling Crittercism.sendAppLoadData().

For library versions 3.1.4 and above, use an instance of CrittercismConfig as demonstrated in the following code:

import com.crittercism.app.Crittercism;
import com.crittercism.app.CrittercismConfig;

import android.os.Bundle;

@Override protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);

    // Create the CrittercismConfig instance.
    CrittercismConfig config = new CrittercismConfig();
    boolean delaySendingAppLoad = true;
    // Set the boolean in the config object.
    config.setDelaySendingAppLoad(delaySendingAppLoad);
    // Initialize.
    Crittercism.initialize(getApplicationContext(),
        "<CRITTERCISM_APP_ID>", crittercismConfig);
}

// At some later point...
public void sendLoadToCritterz() {
    Crittercism.sendAppLoadData();
}
Optional Configuration Parameters

Note
Supported as of library version 3.0.0.
As of library version 3.0.0, the initialization call can receive an optional configuration object to customize settings for logcat collection, version names, and app load request timing.

For library versions 3.1.4 and above, the configuration settings can be set in the fashion demonstrated below:

import com.crittercism.app.Crittercism;
import com.crittercism.app.CrittercismConfig;

import android.os.Bundle;

@Override protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);

    boolean delaySendingAppLoad = true;
    boolean shouldCollectLogcat = true;
    boolean shouldIncludeVersionCode = true;
    String myCustomVersionNmae = "someversion";
    String rateMyAppTestTarget = "http://some.test.target/";
    boolean ndkCrashReportingEnabled = true;

    // Create the CrittercismConfig instance.
    CrittercismConfig config = new CrittercismConfig();
    // Enable the settings.
    config.setDelaySendingAppLoad(delaySendingAppLoad);
    config.setLogcatReportingEnabled(shouldCollectLogcat);
    config.setVersionCodeToBeIncludedInVersionString(shouldIncludeVersionCode);
    config.setCustomVersionName(myCustomVersionName);
    if (BuildConfig.DEBUG) {
        config.setRateMyAppTestTarget(rateMyAppTestTarget); // 3.2.0 and above!  FOR TESTING PURPOSES ONLY!!!!
    }

    config.setNdkCrashReportingEnabled(ndkCrashReportingEnabled);   // NDK Library only!


   // Initialize.
    Crittercism.initialize(getApplicationContext(),
        "<CRITTERCISM_APP_ID>", config);
}
The CrittercismConfig object has the following API calls:

API Call	Description
setDelaySendingAppLoad(boolean)	If this parameter is set to true, Crittercism will not send app load data immediately on app load. App load data can be sent later with Crittercism.sendAppLoadData().
setLogcatReportingEnabled(boolean)	If this parameter is set to true, Crittercism will send logcat data for your application on Jelly Bean devices. For more information, see Including Logcat.
setVersionCodeToBeIncludedInVersionString(String)	If this parameter is set to true, Crittercism will include version code in the version name. For more information, see Include Version Code.
setCustomVersionName(String)	This call allows you to send a customized version name to the server in place of the version name specified in the AndroidManifest.xml file.
setRateMyAppTestTarget(String)	If you want to test the Rate My App feature on an undistributed version of your app, you can pass in a string to this method to specify a test URI (in place of the app market). For more information, see Rate My App. NOTE: Do NOT use this in production builds!!!
setNdkCrashReportingEnabled(boolean)	If this parameter is set to true, then NDK versions of the library will be able to report NDK crashes. For libraries with the _sdkonly suffix, this call does nothing.