using System;

namespace _ConstructorsInheritance
{

	// During Object Istantiation:
	// 1. Base class constructors always executed first
	// 2. Base class construcors are not inherited

	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

	public class Vehicle
	{
		public Vehicle()
		{
			Console.WriteLine("Vehicle is being initialized");
		}
	}

	public class Car : Vehicle
	{
		public Car()
		{
			Console.WriteLine("Car is being initialized");
		}
	}
}
