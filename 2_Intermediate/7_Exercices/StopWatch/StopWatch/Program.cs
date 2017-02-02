using System;
using System.Timers;


namespace StopWatch
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("STOPWACH PROGRAM");
			Console.WriteLine("================");

			var myStopWatch = new StopWatch();

			Console.WriteLine("Timer: " + myStopWatch._time);

		}
	}
}
