using System;
using System.Timers;

namespace StopWatch
{

	public class StopWatch
	{
		public Timer _time{ get; set;} // PROP


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

		public double Intervalo()
		{
			return _time.Interval;
		}
	}
}
