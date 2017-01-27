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

		//method overloading 1

		//public void Move(Point newLocation) 
		//{
		//	this.X = newLocation.X;
		//	this.Y = newLocation.Y;
		//}

		//method overloading 2 so we do not repeat X and Y

		public void Move(Point newLocation)
		{
			// Defensive Programming to make sure points are not null
			if (newLocation == null)
				throw new ArgumentNullException("newLocation");
			Move(newLocation.X, newLocation.Y);
		}

		public void Move(Point newLocation, int speed) { }
	}
	
}
