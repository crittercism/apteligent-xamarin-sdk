Developer Notes
===

Folder Hierarchy notes

- ```samples/``` folder instead of ```testproj/``` as originally discussed to conform with the [Xamarin Template](https://github.com/xamarin/component-template) , verify with Brian if this is acceptable.
- ```component/``` and ```documentation/``` folders to conform with the [Xamarin Template](https://github.com/xamarin/component-template) 
- 
- 

##Punch List Status


###Android 

[Xamarin-TestApp-Android crash-summary ](https://app.crittercism.com/developers/crash-summary/537fc935b573f15751000002)

```
App Name: Xamarin-TestApp-Android
Crittercism App ID: 537fc935b573f15751000002
API Key: CR0TyOGLxLe5u5cLnH4TGYo7z7yDiyyk

Crittercism.initialize(getApplicationContext(), "537fc935b573f15751000002");
```

- [ ] Binding SDK Android
	- [x] Verify DidCrashOnLoad , 
	- [x] Verify 'attach user meta data',
	- [x] Verify Leave Breadcrumb, 
	- [ ] Verify Crash Native
	- [ ] Verify Native Exception
	- [ ] Verify Crash CLR
	- [ ] Verify CLR Excption
	- [ ] dsym upload
- [ ] Sample App Android
- [ ] Simulator Test -  API 15
- [ ] Device Test - LG Nexus 5 


###iOS

[Xamarin-TestApp-iOS crash-summary ](https://app.crittercism.com/developers/crash-summary/5342d5a70ee9483d74000007)

```
App Name: Xamarin-TestApp-iOS
Crittercism App ID: 53433aee40ec926441000002
API Key: jgamwbghdxpe7kolfnruhyds10bcxvna

[Crittercism enableWithAppID:@"53433aee40ec926441000002"];
```



- [ ] Binding SDK iOS
	- [x] Verify DidCrashOnLoad , 
	- [x] Verify 'attach user meta data',
	- [x] Verify Leave Breadcrumb, 
	- [ ] Verify Crash Native
	- [ ] Verify Native Exception
	- [ ] Verify Crash CLR
	- [ ] Verify CLR Excption
	- [ ] dsym upload - requires new .a library
- [ ] Sample App iOS
- [ ] Simulator Test - iOS 7
- [ ] Device Test - iOS 7.1


###Scripts
- [ ] [Build Script](/scripts/build.sh)

###Documentation

- [ ] [README.md](README.md)
- [ ] Xamarin Crittercsim Overview

###Misc Notes

- [ ] CLR Stack tracing, clr update ( NSException - Hacky way ) 
	- C# Exceptions 
 	- logUnityException ( convert to the windows exception and sends to endpoint, as a Windows excption )
 	- hook global exception handler it into 
	- Diagnostics ( app version, battery, etc ... )
	- Check for an update on the unity library.
	- https://github.com/crittercism/crittercism-unity-ios/blob/feature/exception-cleanup/Plugins/Crittercism_IOS_Scripts/CrittercismIOS.cs#L169


--- 

##Xamarin Network Notes


2 Main classes for accessing network resources

### WebClient 

WebClient also has DownloadFileCompleted and DownloadFileAsync for retrieving binary data

```
var webClient = new WebClient ();
webClient.DownloadStringCompleted += (sender, e) =>
{
    var resultString = e.Result;
    // do something with downloaded string, do UI interaction on main thread
};
webClient.Encoding = System.Text.Encoding.UTF8;
webClient.DownloadStringAsync (new Uri ("http://some-server.com/file.xml"));
```

### HttpWebRequest


HttpWebRequest offers more customization than WebClient and as a result requires more code to use.

```
var request = HttpWebRequest.Create(@"http://some-server.com/file.xml ");
request.ContentType = "text/xml";
request.Method = "GET";
using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
{
    if (response.StatusCode != HttpStatusCode.OK)
        Console.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
    {
        var content = reader.ReadToEnd();
        // do something with downloaded string, do UI interaction on main thread       
    }
}
```



- NSURLConnection 

- CLR 
- dsym upload. 
- 



###Xamarin Android


[java intergration overview](http://docs.xamarin.com/guides/android/advanced_topics/java_integration_overview/binding_a_java_library_(.jar)/)

Xamarin.Android has two ways to use these libraries, either use the Java Native Interface (JNI) to invoke the calls directly, or create a binding project that automatically wraps the library with C# wrappers based on a declarative approach.

Xamarin.Android 4.2, a new project template is available

The difference between EmbeddedJar and InputJar is, EmbeddedJar is to be
embedded in the resulting dll as EmbeddedResource, while InputJar is not.

**Currently and EmbeddedJar**






---

How are things going with the Android plugin?

I'm attaching a Crittercism library that I've modified to allow logging handled exceptions.
Here's how these will be called in our Unit plugin.
https://github.com/crittercism/crittercism-unity-ios/blob/feature/exception-cleanup/Plugins/Crittercism_IOS_Scripts/CrittercismIOS.cs#L98


void Crittercism_EnableWithAppID(const char* appID)

void Crittercism_LogHandledException(const char* name,
                                     const char* reason,
                                     const char *stack)

void Crittercism_LogUnhandledException(const char* name,
                                       const char* reason,
                                       const char *stack)




void Crittercism_LeaveBreadcrumb(const char* breadcrumb)
void Crittercism_SetAsyncBreadcrumbMode(bool writeAsync)
void Crittercism_SetUsername(const char* username)
void Crittercism_SetValue(const char* value, const char* key)
bool Crittercism_GetOptOutStatus()
void Crittercism_SetOptOutStatus(bool status)

---







