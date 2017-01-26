using System;

namespace ObjectInitializers
{

	// Object Initializers

	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}


	// ctor: To initialize an object and put it into an early state.
	// object initializer: A syntax to initialize an object without the need to 
	// initialize one of its constructors.
	// Why? To avoid creating multiple ctors.

	public class PersonA
	{
		public int Id;
		public string FirstName;
		public string SecondName;
		public DateTime BirthDate;

		// ctor1 Default
		PersonA() { }

		// ctor2
		PersonA(int id) { }

		// ctor3
		PersonA(int id, string firstName) { }

		// ctor4
		PersonA(int id, string firstName, string secondName) { }

		// ctor5
		PersonA(int id, DateTime birthdate) { }

		//using Object Initializer
		var person1 = new PersonA
		{
			Id = 21,
			FirsName = "Bernat",
			SecondName = "Ferragut",
			BirthDate = 01:01:1999
		};
	}



}
