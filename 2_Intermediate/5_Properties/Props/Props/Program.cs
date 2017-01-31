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
		private DateTime _birthdate; // Declare as private

		public void SetBirth(DateTime Birthdate) // Setter
		{
			this._birthdate = Birthdate;
		}

		public DateTime SetBirth() // Getter
		{
			return _birthdate;
		}
	}

	// We can avhieve the same with a Property

	public class Person1
	{
		private DateTime _birthdate;

		public DateTime Birthdate
		{
			get { return _birthdate; }
			set { _birthdate = value; }
		}
	}

}
