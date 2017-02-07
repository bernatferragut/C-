using System;

// HAS A relationship ( Car has an engine )
// Flexibility
// Loosely coupled
// the Related Class is simply a private field

namespace Composition
{
	public class Logger
	{
		// Method
		public void Log(string message)
		{
			Console.WriteLine(message);
		}
	}
}
