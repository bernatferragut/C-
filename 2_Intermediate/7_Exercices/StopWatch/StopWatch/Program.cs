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

			myStopWatch.Play();
			myStopWatch.Stop();

			// var timePassed = Convert.ToString( myStopWatch.ShowTime()); // Op 1
			var timePassed = TimeSpan.FromSeconds(myStopWatch.ShowTime()); // Op 2

			Console.WriteLine("Timer: " + timePassed);
		}
	}
}
