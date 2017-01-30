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
		private string Name;

		public void GetName(string name)
		{
			if (!String.IsNullOrWhiteSpace(name)) // we include a condition
			{
				this.Name = name;
			}
		}

		public string SetName()
		{
			return Name;
		}
	}
}
