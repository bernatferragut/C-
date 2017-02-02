using System;

namespace StopWatch
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("STOPWACH PROGRAM");
			Console.WriteLine("================");

			var myStopWatch = new StopWatch(new DateTime(11/10/09));
			Console.WriteLine(myStopWatch.Play());
			Console.WriteLine(myStopWatch.Stop());
			Console.WriteLine(myStopWatch.ReStart());
		}
	}
}
