using System;

namespace ObjectInitializers
{

	// Object Initializers

	class MainClass
	{
		public static void Main(string[] args)
		{
			//Con//using Object Initializer
			var person1 = new PersonA
			{
				Id = 21,
				FirstName = "Bernat",
				SecondName = "Ferragut",
			};

			var person2 = new PersonA
			{
				Id = 31,
				FirstName = "Laurent",
				SecondName = "Ferragut",
			};
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
		public PersonA() { }

		// ctor2
		public PersonA(int id) { }

		// ctor3
		 public PersonA(int id, string firstName) { }

		// ctor4
		public PersonA(int id, string firstName, string secondName) { }

		// ctor5
		 public PersonA(int id, DateTime birthdate) { }

	}
}
