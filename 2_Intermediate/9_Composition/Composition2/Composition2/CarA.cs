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

	public class CarA
	{
		readonly Auto _auto;

		public CarA(Auto auto)
		{
			this._auto = auto;
		}

		public void SpeedA()
		{
			Console.WriteLine("I'm runnning at super speed A");
		}
	}
}
