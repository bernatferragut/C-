using System;

namespace AccMod
{
	// 1.Public
	// 2.Private
	// 3.Protected
	// 4.Internal
	// 5.Protected Internal
	// A way to control access to a class and or its memebers ti improve robustness

	// A. ENCAPSULATION or INFORMATION HIDING

	class MainClass
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
		}
	}

	public class Person
	{
		private string _name; //  we cannot access the name

		public void SetName(string name) // we can only access through the method 
		{
			if (!String.IsNullOrWhiteSpace(name)) // we include a condition
			{
				this._name = name;
			}
		}

		public string GetName()
		{
			return _name;
		}
	}
}
