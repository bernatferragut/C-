using System;
using System.IO;
using System.Collections.Generic;

namespace Methods_1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var myPoint = new Point(2,3);

			myPoint.Move(new Point(2, 2));
			Console.WriteLine(" My Point is in {0}X and in {1}Y", myPoint.X, myPoint.Y);
	

			//var myCalculator = new Calculator();
			//myCalculator.Add(new int[] { 0, 1020, 30, 44 });

			//var myCalculator2 = new Calculator();
			//myCalculator2.Add2(0, 10, 2, 3, 4);
		}
	}
}
