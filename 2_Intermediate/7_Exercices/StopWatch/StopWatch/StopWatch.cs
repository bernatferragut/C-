using System;
using System.Timers;

namespace StopWatch
{

	public class StopWatch
	{
		public Timer _time{ get; private set;} // PROP

		public StopWatch(Timer Time) // CTOR
		{
			this._time = Time;
		}

		public Timer Play() // MTHD1
		{
			return _time.Start();
		}

		public Timer Stop() // MTHD2
		{
			return _time.Stop();
		}

		public Timer ReStart() // MTHD3
		{
			return _time.AutoReset();
		}
	}
}
