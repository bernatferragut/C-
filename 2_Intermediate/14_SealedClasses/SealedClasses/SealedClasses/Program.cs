// Sealed Classes and Members
// Prevents derivation of classes or overriding of Methods


using System;

namespace SealedClasses
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

	// Overriding Class Example
	// We cannot make a class derived from Circle
	public sealed class Circle : Shape
	{
		public override void Draw();
		{
			Console.WriteLine ("Drawing a Circle");
		}
	}
}
