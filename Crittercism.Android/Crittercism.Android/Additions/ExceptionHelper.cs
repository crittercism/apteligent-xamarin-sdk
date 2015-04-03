using System;
using Java.Lang;
using System.Diagnostics;
using System.Collections.Generic;
using Android.Util;

namespace CrittercismAndroid
{
	internal class ExceptionHelper
	{
		////////////////////////////////////////////////////////////////
		// DESIGN: We aren't thrilled with this code...
		// * We want to report C# InnerException's here too (of course).
		// There's distaste for the existing mechanism of converting into a
		// Java.Lang.Exception as a middle stop on the way to sending JSON
		// crash reports and HE reports to platform.
		// * We are just accepting the Crittercism-android Java.Lang.Exception
		// mode of business for now.  So, we just try to get C# exceptions
		// to bend over backwards and make it fit inside a Java.Lang.Exception .
		// * When we can afford more time, this entire file should be tossed.
		////////////////////////////////////////////////////////////////

		private static List<Java.Lang.StackTraceElement> StackTraceIndividual(System.Exception e)
		{
			List<Java.Lang.StackTraceElement> answer = null;
			if (e.StackTrace != null) {
				answer = new List<Java.Lang.StackTraceElement>();
				StackTrace stackTrace = new StackTrace(e, true);
				for (int i = 0; i < stackTrace.FrameCount; i++) {
					StackFrame frame = stackTrace.GetFrame(i);
					Java.Lang.StackTraceElement javaStackElement = new Java.Lang.StackTraceElement(
						frame.GetMethod().DeclaringType.Name,
						frame.GetMethod().Name,
						frame.GetFileName(),
						frame.GetFileLineNumber());
					answer.Add(javaStackElement);
				}
			}
			return answer;
		}

		private static Java.Lang.StackTraceElement StackTraceName(System.Exception e)
		{
			// "MyClass.mash(MyClass.java:9)" ...
			// StackTraceElement(String declaringClass, String methodName, String fileName, int lineNumber)
			Java.Lang.StackTraceElement answer = new Java.Lang.StackTraceElement(
				e.GetType().FullName,
				e.Message,
				"",
				0);
			return answer;
		}

		private static Java.Lang.StackTraceElement StackTraceBoundary(System.Exception e)
		{
			// "MyClass.mash(MyClass.java:9)" ...
			// StackTraceElement(String declaringClass, String methodName, String fileName, int lineNumber)
			Java.Lang.StackTraceElement answer = new Java.Lang.StackTraceElement(
				"----------------------------------------------------------------",
				"",
				"",
				0);
			return answer;
		}

		private static List<Java.Lang.StackTraceElement> StackTraceGroup(System.Exception e)
		{
			// Allowing for the fact that the "name" and "reason" of the outermost
			// exception e are already shown in the Crittercism portal, we don't
			// need to repeat that bit of info.  However, for InnerException's, we
			// will include this information in the StackTrace .  The horizontal
			// lines (hyphens) separate InnerException's from each other and the
			// outermost Exception e .

			List<Java.Lang.StackTraceElement> answer = StackTraceIndividual(e);
			if (answer == null) {
				// Assuming the Exception e being passed in hasn't been thrown.  In this case,
				// supply our own current "stacktrace".
				try {
					throw new System.Exception();
				} catch (System.Exception e2) {
					answer = StackTraceIndividual(e2);
				}
			} else {
				System.Exception ie = e.InnerException;
				while (ie != null) {
					// NOTE: Written in the same spirit as Xamarin Crittercism.iOS but
					// while wearing java.lang.Exception and java.lang.StackTraceElement
					// colored glasses.  (Not the most ideal code.)  Similar to:
					//answer = ((ie.GetType().FullName + " : " + ie.Message + "\r\n")
					//	+ (ie.StackTrace + "\r\n")
					//	+ "----------------------------------------------------------------\r\n"
					//	+ answer);
					List<Java.Lang.StackTraceElement> list = new List<Java.Lang.StackTraceElement>();
					list.Add(StackTraceName(ie));
					list.AddRange(StackTraceIndividual(ie));
					list.Add(StackTraceBoundary(ie));
					list.AddRange(answer);
					answer = list;
					ie = ie.InnerException;
				}
			}
			return answer;
		}

		// Takes the contents of a C# exception and stuffs them into a java exception.
		// This is used to feed into the Crittercism Android SDK.
		internal static Java.Lang.Exception createJavaException( System.Exception e )
		{
			Java.Lang.Exception javaLangException = new Java.Lang.Exception (e.Message);
			StackTrace stackTrace = new StackTrace (e, true);
			Java.Lang.StackTraceElement[] javaStackElements = StackTraceGroup(e).ToArray();
			javaLangException.SetStackTrace (javaStackElements);
			return javaLangException;
		}
	}
}

