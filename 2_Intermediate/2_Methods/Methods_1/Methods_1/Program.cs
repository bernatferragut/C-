using System;
using System.IO;
using System.Collections.Generic;

namespace Methods_1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
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
