// Interfaces and Extensability

using System;

namespace Interfaces_3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//
		}
	}

	public class ConsoleLogger : ILogger
	{
		public void LogError(string message)
		{
			throw new NotImplementedException();
		}

		public void LogInfo(string message)
		{
			throw new NotImplementedException();
		}
	}
}
