// Method Overriding
// Modifyinf the implementation of an inherited Method
// We need to encapsulate data and behaviour in one Class

using System;

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
		
	}

	public class Rectangle : Shape
	{
		
	}

	public class Canvas
	{
		public void DrawShapes(List<Shape> shapes)
		{
			
		}
	}
}
