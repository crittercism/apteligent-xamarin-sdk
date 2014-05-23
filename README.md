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

##Getting Started

###Prerequisities

You need to have installed Xamarin in your developer machine, you can download it from [Xamarin.com/download](http://xamarin.com/download).

Native Tools for iOS and Android.


##Project Organization


##Sample Application


##Running the Tests




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








