using System;

namespace StopWatch
{

	public class StopWatch
	{
		public DateTime _time{ get; private set;} // DateTime Property with private set field

		public StopWatch(DateTime Time) // How to set privately Time through a constructor
		{
			this._time = Time;
		}
	}
}
