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

	public class Person1
	{
		public int Id;
		public string FirstName;
		public string SecondName;
		public DateTime BirthDate;

		// ctor1
	}
}
