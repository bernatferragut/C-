using System;

namespace Props
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

	public class Person
	{
		private DateTime _birthdate;

		public void SetBirth(DateTime Birthdate) // Setter
		{
			this._birthdate = Birthdate;
		}

		public DateTime SetBirth() // Getter
		{
			return _birthdate;
		}
	}
}
