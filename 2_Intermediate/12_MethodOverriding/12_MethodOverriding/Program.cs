// Method Overriding
// Modifyinf the implementation of an inherited Method
// We need to encapsulate data and behaviour in one Class

using System;
using System.Collections.Generic;

namespace _MethodOverriding
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Code
		}
	}

	public class Shape
	{
		public int Width { get;set; }
		public int Height { get;set; }
		public Position Position { get; set; }

		public virtual void Draw()
		{
			
		}
	}

	public class Circle : Shape
	{
		public override void Draw()
		{
			//base.Draw();
			Console.WriteLine(" Draw a Circle");
		}
	}

	public class Rectangle : Shape
	{
		public override void Draw()
		{
			//base.Draw();
			Console.WriteLine(" Draw a Rectangle");
		}
	}

	public class Canvas
	{
		public void DrawShapes(List<Shape> shapes)
		{
			foreach (var shape in shapes)
			{
				shape.Draw();
			}
		}
	}
}
