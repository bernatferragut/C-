using System;
using Classes.Math;

namespace Classes
{
	class Program
	{
		public static void Main(string[] args)
		{
			Person bernat = new Person();

			bernat.firstName = "Bernat";
			bernat.secondName = "Ferragut";
			bernat.Introduce();

			Calculator calculator = new Calculator();
			var result = calculator.Add(3, 2);
			Console.WriteLine(result);

		}
	}
}
