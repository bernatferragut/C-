using System;

namespace _Inheritance
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

	// Inheritamce 'IS A' relationship - Common 'behaviours' and 'porperties' are inherited
	// Code reuse
	// Polymorphism
	// Parent or Super Class - vs - Child or Sub Class

	public class PresentationObject
	{
		// Props
		public int Width{ get; set; }

		public int Hieght{ get; set; }

		//Methods
		public void Copy()
		{
			Console.WriteLine("Object Copied to clipboard");
		}

		public void Paste()
		{
			Console.WriteLine("Object was Pasted to file");
		}
	}
}
