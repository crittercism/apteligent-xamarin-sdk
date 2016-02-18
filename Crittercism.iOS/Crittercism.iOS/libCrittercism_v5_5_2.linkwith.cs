using System;
using ObjCRuntime;

[assembly: LinkWith ("libCrittercism_v5_4_2.a",
	LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator64 | LinkTarget.Arm64,
	SmartLink = true,
	ForceLoad = true,
	Frameworks = "SystemConfiguration")]
