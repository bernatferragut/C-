using System;
using System.Timers;

namespace StopWatch
{
	public class StopWatch
	{
		//Params
		public Timer _time{ get; set;} // PROP

		//Metods

		public double ShowTime() // MTHD0
		{
			return _time.Interval;
		}

		public void Play() // MTHD1
		{
			_time.Start();
		}

		public void  Stop() // MTHD2
		{
			_time.Stop();
		}

		public void ReStart() // MTHD3
		{
			_time.BeginInit();
		}
	}
}
