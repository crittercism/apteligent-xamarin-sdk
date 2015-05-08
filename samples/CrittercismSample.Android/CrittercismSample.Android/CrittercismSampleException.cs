using System;

namespace CrittercismSample.Android
{
	public class CrittercismSampleException : Exception
	{
		public CrittercismSampleException()
		{
		}

		public CrittercismSampleException(string message)
			: base(message)
		{
		}

		public CrittercismSampleException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}

