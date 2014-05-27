Xamarin, Crittercism Component Package
=======

**Work In Progresss**

Performance Monitor, prioritize, troubleshoot, and trend your mobile cross-platform [Xamarin](http://xamarin.com) mobile app with [Crittercism](http://crittercism.com) C# Component.

A cross-platform Component for leveraging Crittercism SDK and Services from Xamarin ( Mono  C# ) iOS and Android Applicaion

Please read Getting Started to learn how to use the component library.

##Key Highlights

- highlight 1
- highlight 2
- highlight 3

##Xamarin Crittercisms overview

todo



###iOS 

####iOS AOT Xamarin Limitations

Since applications on the iPhone using Xamarin.iOS are compiled to static code, it is not possible to use any facilities that require code generation at runtime. Unlike Android (JIT just-in compiler time) architecture iPhones kernel prevents an application from generating code dynamically Mono on the iPhone does not support any form of dynamic code generation.  This can cause limitations in supported C#/.Net featurtes such as Generics and generic subclassing, P/Invokes and System.Reflect.Emit.  You can find out more about Xamarin iOS AOT Limitations here [Xamarin Limitations](http://docs.xamarin.com/guides/ios/advanced_topics/limitations/ "Limitations | Xamarin")


###Android

Xamarin.Android applications run within the Mono execution environment. This execution environment runs side-by-side with the Dalvik Virtual Machine.  Both runtime environments run on top of the Linux kernel and expose various APIs to the user code that allows developers to access the underlying system.  You can find out more about the Xamarin Android Architecture on the [Xamarin documentation page Overview](http://docs.xamarin.com/guides/android/under_the_hood/architecture/ "Architecture | Xamarin").



##Getting Started

###Prerequisities

You need to have installed Xamarin in your developer machine, you can download it from [Xamarin.com/download](http://xamarin.com/download).

Native Tools for iOS and Android.


###Getting Started with Android

1. Create a new Xamarin Android Project
1. Add the Crittercsim Library
1. Import namespace `using Com.Crittercism.App;`
1. Configure Manifest Provisions for [Xamarin Android Applicaion configuration](/screenshots/Xam-Android-Manifest.png)
	- <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE"/>
	- <uses-permission android:name="android.permission.GET_TASKS"/>
	- <uses-permission android:name="android.permission.INTERNET"/>
	- <uses-permission android:name="android.permission.READ_LOGS"/>
1. Initialize Crittercism in `protected override void OnCreate (Bundle bundle)`

```
//Initialize Crittercism
Crittercism.Initialize( ApplicationContext, "537fc935b573f15751000002");

//Set the Username
Crittercism.SetUsername ("ANDROID_USER_NAME");
```

1. Uploading the mapping.txt File 


For more information regarding the Xamarin Android Crittercsim refer to the  [Crittercism docs](http://docs.crittercism.com/android/android.html)



###Getting Started with iOS

1. Create a new Xamarin iOS Project
1. Add the Crittercsim Library
1. Import namespace `using Crittercism;`
1. Configure correct Provisions for 
1. Initialize Crittercism 

For more information regarding the Xamarin Android Crittercsim refer to the  [Crittercism docs](http://docs.crittercism.com/android/android.html)


##Sample Application

Sample Application demonstrating using the Crittercsism Xamarin Component for iOS and Android

###iOS Sample Application

Open and run  the iOS Sample app located at `samples/CrittercismSample.iOS/CrittercismSample.iOS.sln`

###Android Sample Application

Open run the Android Sample app located at `samples/CrittercismSample.Android/CrittercismSample.Android.sln`

##Building the Xamarin Component

- Build Xamarin.iOS and Xamarin.Android dlls ( Release )
- Run the component Rake see [ component README.md ]( /component/README.md )

##Release Notes



##Misc Notes

With the [xamarin.iOS 7.2 Release](http://docs.xamarin.com/releases/ios/xamarin.ios_7/xamarin.ios_7.2/) [registrars](http://docs.xamarin.com/guides/ios/advanced_topics/registrar/) are enabled by default.  During startup, Xamarin.iOS will register managed classes and methods with the Objective-C runtime. This allows managed classes to be created and managed methods to be called from Objective-C and is the way that methods and properties are linked between the C# world and the Objective-C one.

This new registration system offers the following new features:

- Compile time detection of programmer errors:

	- Two classes being registered with the same name.
	- More than one method exported to respond to the same selector

- Can remove unused native code

	- The new registration system will add strong references to code used in static libraries, allowing the native linker to strip out unused native code from the resulting binary.
	- On Xamarin's sample bindings, most applications become 300k smaller.

- Support for generic subclasses of NSObject. See NSObject Generics for more information. Additionally the new registration system will catch unsupported generic constructs which would previously have caused random behavior at runtime.








