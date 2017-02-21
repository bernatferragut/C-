// Interfaces and Extensability

using System;

namespace Interfaces_3
{

	public class ConsoleLogger : ILogger
	{
		public void LogError(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
		}

		public void LogInfo(string message)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(message);
		}
	}
}
