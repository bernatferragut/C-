// Abstract Classes
// Indicates that a class or member is missing implementation

using System;

namespace AbstractClasses
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var circle = new Circle();
			circle.Draw();

			var rectangle = new Rectangle();
			rectangle.Draw();
				
		}
	}

	public class Rectangle : Shape
	{
		public void Draw()
		{
			Console.WriteLine("Draw a Rectangle");
		}
	}

	//// OLD EXAMPLE
	//public class Shape
	//{
	//	public virtual void Draw() // virtual
	//	{
	//		// How to draw a shape ? The concept of a shape is too abstact
	//	}
	//}

	//public class Circle : Shape
	//{
	//	public override void Draw()
	//	{
	//		Console.WriteLine(" Draw a circle");
	//	}
	//}

	//// WITH THE ABSTRACT MODIFIER
	//public abstract class Shape2 // abstarct class // They cannot be instantiated
	//{
	//	public abstract void Draw2(); // abstract method pass without implemention
	//}

	//public class Circle2 : Shape2
	//{
	//	public override void Draw2()
	//	{
	//		// Downstream the method is implemented
	//	}
	//}
}
