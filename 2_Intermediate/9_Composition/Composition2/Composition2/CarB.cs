using System;

// Favour Composition over Inheritance

// Problems with Inheritance ( IS A Relationship )
// 1- Easely abused by amateur developers
// 2- Large Hierarchies
// 3- Fragility
// 4- Tightly Coupled

// Compoistion ( HAS A Relationship )

//1- We get great flexibility
//2- Eventually loose coupling 

namespace Composition2
{

	public class CarB
	{
		readonly Auto _auto;

		public CarB(Auto auto)
		{
			this._auto = auto;
		}

		public void Starter()
		{
			_auto.Start();
		}

		public void Stopper()
		{
			_auto.Stop();
		}

		public void SpeedB()
		{
			Console.WriteLine("I'm runnning at super speed B");
		}
	}
}
