// Sealed Classes and Members
// Prevents derivation of classes or overriding of Methods


using System;

namespace SealedClasses
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Code
		}
	}

	// Overriding Class Example
	// We cannot make a class derived from Circle
	// Sealed Classes are slightly faster because of run-time optimizations
	// Hardly ever used
	// As a guideline do not use it

	public sealed class Circle : Shape
	{
		public override void Draw();
		{
			Console.WriteLine ("Drawing a Circle");
		}
	}
}
