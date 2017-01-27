using System;
using System.IO;
using System.Collections.Generic;

namespace Methods_1
{

	public class Point
	{
		public int X;

		public int Y;

		//ctor
		public Point(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}
		//method
		public void Move(int x, int y) 
		{
			this.X = x;
			this.Y = y;
		}

		//method overloading

		public void Move(Point newLocation) 
		{
			this.X = newLocation.X;
			this.Y = newLocation.Y;
		}

		public void Move(Point newLocation, int speed) { }
	}
	
}
