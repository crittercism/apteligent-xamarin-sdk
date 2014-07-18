MVVMCross - Sample
===

MVVMCross Sample with Crittercism crash reporting

Requires:

- CrossLight 2.0.0
- Crittercism Xamarin SDK

Dev Notes:

MVVMCross requires calling the base.FinishedLaunching after initializing  Crittercism 

```
public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
{
	Crittercism.Init ("5555555553fb79451d000002");
	
	return base.FinishedLaunching (application, launchOptions);
}
```



