using System;

namespace _ConstructorsInheritance
{

	// During Object Istantiation:
	// 1. Base class constructors always executed first
	// 2. Base class construcors are not inherited

	public class Car : Vehicle
	{
		public Car(string RegistrationNumber) // We pass this parameter to the Vehicle base class
			: base(RegistrationNumber)
		{
			Console.WriteLine("Car is being initialized. {0}", RegistrationNumber);
		}
	}
}
