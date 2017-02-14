// Abstract Classes
// Indicates that a class or member is missing implementation

using System;

namespace AbstractClasses
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

	// OLD EXAMPLE

	public class Shape
	{
		public virtual void Draw() // virtual
		{
			// How to draw a shape ?
		}
	}

	public class Circle : Shape
	{
		public override void Draw()
		{
			Console.WriteLine(" Draw a circle");
		}
	}
}
