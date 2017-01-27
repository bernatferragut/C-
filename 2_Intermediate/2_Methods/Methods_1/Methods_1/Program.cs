using System;
using System.IO;
using System.Collections.Generic;

namespace Methods_1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var myPoint = new Point();
			myPoint.Move(3, 4);
		}
	}

	public class Point
	{
		int x;

		int y;

		public void Move(int x, int y) { }

		//Overloading

		public void Move(Point newLocation) { }

		public void Move(Point newLocation, int speed) { }
	}
}
