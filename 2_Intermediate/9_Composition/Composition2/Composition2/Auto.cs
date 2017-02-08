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

	public class Auto
	{
		public void Start()
		{
			Console.WriteLine("Engine Started");
		}

		public void Stop()
		{
			Console.WriteLine("Engine Stopped");
		}
	}
}
