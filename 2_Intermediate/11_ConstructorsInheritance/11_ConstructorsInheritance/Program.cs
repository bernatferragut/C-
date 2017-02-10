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
			var car = new Car("ABC123");
		}
	}
}
