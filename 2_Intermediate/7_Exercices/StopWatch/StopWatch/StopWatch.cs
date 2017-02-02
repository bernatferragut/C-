using System;

namespace StopWatch
{

	public class StopWatch
	{
		public DateTime _time{ get; private set;} // PROP

		public StopWatch(DateTime Time) // CTOR
		{
			this._time = Time;
		}

		public int Play() // MTHD1
		{
			return _time.Hour;
		}

		public int Stop() // MTHD2
		{
			return _time.Minute;
		}

		public int ReStart() // MTHD3
		{
			return _time.Second;
		}
	}
}
