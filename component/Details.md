Crittercsim Xamarin component allows you to easily add crash analytics to your Xamarin and iOS mobile applicaion giving you access to Crittercism crash detection featues

- feature 1
- feature 1
- feature 1
- feature 1

Integration into your applicaion is easy


Xamarin Android integration

```csharp
using Com.Crittercism.App;
...

protected override void OnCreate (Bundle bundle)
{
			//Initialize Crittercism
			Crittercism.Initialize( ApplicationContext, "CRITTERCISM_ANDROID_APP_ID");
			
			//Set the Username
			Crittercism.SetUsername ("ANDROID_USER_NAME");
			
			base.OnCreate (bundle);
}
```


Xamarin iOS integration

```csharp
using Crittercism;
...

public override void ViewDidLoad ()
{
	// Show the user how to setup your component
}

```


