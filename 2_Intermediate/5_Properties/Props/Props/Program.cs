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
		private DateTime _birthdate; // field

		public DateTime Birthdate // properties
		{
			get { return _birthdate; }
			set { _birthdate = value; }
		}
	}

	// even simpler with auto implemented properties

	public class Person2
	{
		public DateTime Birthdate { get; set; } //  internally creates a private field and getters and setters 

		public int Age
		{
			get //  we include some logic cause years are based on birthdate
			{
				var timeSpan = DateTime.Today - Birthdate;
				var years = timeSpan.Days / 360;
				return years;
			}
		}
	
	}

}
