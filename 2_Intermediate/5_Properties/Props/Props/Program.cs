using System;

namespace Props
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var Persona = new Person2();
			Persona.Birthdate = new DateTime(1992, 01, 01);
			Console.WriteLine(Persona.Age);
		}
	}
}
