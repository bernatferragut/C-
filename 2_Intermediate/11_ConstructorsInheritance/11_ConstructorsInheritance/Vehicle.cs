using System;

namespace _ConstructorsInheritance
{

	// During Object Istantiation:
	// 1. Base class constructors always executed first
	// 2. Base class construcors are not inherited

	public class Vehicle
	{
		public Vehicle()
		{
			Console.WriteLine("Vehicle is being initialized");
		}
	}
	
}
