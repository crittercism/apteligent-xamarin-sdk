using System;
using ObjCRuntime;

[assembly: LinkWith ("libCrittercism_v5_1_6.a", LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64, ForceLoad = true, Frameworks = "SystemConfiguration")]
