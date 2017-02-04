using System;
using System.Diagnostics;
using System.Threading;

namespace SW
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("STOPWATCH CLASS");
			Console.WriteLine("================");

			var sw = new Stopwatch();

			sw.Start();

			var count1 = 100000f;
			for (var i = 0; i < count1; i++)
			{ Console.WriteLine("Counts: {0}", i); }
			Thread.Sleep(1000); // 10 milisec = 10 sec
			Console.WriteLine("Frist Time Elpased: {0}", sw.Elapsed);

			sw.Reset();
			sw.Restart();

			var count2 = 1000000f;
			for (var i = 0; i < count2; i++)
			{ Console.WriteLine("Counts: {0}", i); }
			Thread.Sleep(10000); // 10 milisec = 10 sec
			Console.WriteLine("Second Time Elpased: {0}", sw.Elapsed);
		}
	}

	class StopWAtch
}
