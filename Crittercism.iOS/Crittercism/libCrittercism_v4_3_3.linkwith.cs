using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libCrittercism_v4_3_3.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s,Frameworks = "CoreLocation", ForceLoad = true)]
