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
	class MainClass
	{
		public static void Main(string[] args)
		{
			var carro1 = new CarA(new Auto());
			carro1.SpeedA();
			carro1.Starter();

			var carro3 = new CarB(new Auto());
			carro3.SpeedB();
			carro3.Stopper();
		}
	}
}
