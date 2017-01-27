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

			var myCalculator = new Calculator();
			myCalculator.Add(new int[] { 0, 1020, 30, 44 });
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

	public class Calculator
	{
		//public int Add(int n1, int n2) { }
		//public int Add(int n1, int n2, int n3) { }
		//public int Add(int n1, int n2, int n3, int n4) { }

		// using an Array to Oveload

		public int Add(int[] numbers) { }

	}
}
