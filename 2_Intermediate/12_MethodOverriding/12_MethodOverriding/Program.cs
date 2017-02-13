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
			var shapes = new List<Shape>();
			shapes.Add(new Circle());
			shapes.Add(new Rectangle());

			var canvas = new Canvas();
			canvas.DrawShapes(shapes);
		}
	}
}
