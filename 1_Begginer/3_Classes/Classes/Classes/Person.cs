using System;

namespace Classes
{
	public class Person
	{
		public string firstName;
		public string secondName;

		public void Introduce()
		{
			Console.WriteLine("My name is " + firstName + " " + secondName);
		}
	}
}
