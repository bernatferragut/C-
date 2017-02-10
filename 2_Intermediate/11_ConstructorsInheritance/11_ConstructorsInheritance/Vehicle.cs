using System;

namespace _ConstructorsInheritance
{

	// During Object Istantiation:
	// 1. Base class constructors always executed first
	// 2. Base class construcors are not inherited

	public class Vehicle
	{

		readonly string _registrationNumber;

		//public Vehicle()
		//{
		//	Console.WriteLine("Vehicle is being initialized");
		//}

		public Vehicle(string RegistrationNumber)
		{
			this._registrationNumber = RegistrationNumber;

			Console.WriteLine("The Registration Number is: {0}", RegistrationNumber);
		}
	}
	
}
