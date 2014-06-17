Crittercsim Xamarin component allows you to easily add crash analytics to your Xamarin and iOS mobile applicaion giving you access to Crittercism crash detection featues

Integration into your applicaion is easy

Xamarin Android integration

```csharp
using CrittercismAndroid;
...

protected override void OnCreate (Bundle bundle)
{
	//Initialize Crittercism with your App ID from crittercism.com
	Crittercism.Init( ApplicationContext,  "99999935b573f15751000002");
			
	//Set the Username
	Crittercism.SetUserName ("ANDROID_USER_NAME");
	
	if (Crittercism.DidCrashOnLastLoad() == true) {
		...
	}
	
	Console.WriteLine ("Check the OptOutStatus " + Com.Crittercism.App.Crittercism.OptOutStatus );
	
	Crittercism.LeaveBreadcrumb( "Android BreadCrumb");
	
}
```

Xamarin iOS integration

In your AppDelegate.cs 

```csharp
using CrittercismIOS;

public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
{
	//Initialize Crittercism with your App ID from crittercism.com
	Crittercism.Init("999999a70ee9483d74000007");
	return true;
}

```

From within your Application ( such as Sample_iOSViewController.cs )

```csharp
using CrittercismIOS;

if (Crittercism.CrashedOnLastLoad == true) {
	...
}

Crittercism.Username = "MyUserName";
Crittercism.SetMetadata("Game Level","5");
Crittercism.LeaveBreadcrumb("My Breadcrumb");

```



