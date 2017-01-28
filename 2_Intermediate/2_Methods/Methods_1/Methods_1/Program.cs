using System;
using System.IO;
using System.Collections.Generic;

namespace Methods_1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var calculator = new Calculator();
			var sum = calculator.Add(1, 2, 3, 4); // Params method
			var sum2 = calculator.Add(new int[] { 1, 2, 3, 4 });
			Console.WriteLine(sum);
			Console.WriteLine(sum2);
		}

		virtual void UsePoints()
		{
			try
			{
				var myPoint = new Point(2, 3);

				// using Methode Overload 1
				myPoint.Move(new Point(2, 2));
				Console.WriteLine(" My Point is at Position {0}X and in {1}Y", myPoint.X, myPoint.Y);

				// using Methode Overload 2
				myPoint.Move(200, 200);
				Console.WriteLine(" My Point is at Position {0}X and in {1}Y", myPoint.X, myPoint.Y);
			}
			catch (Exception)
			{
				Console.WriteLine("An unexpected Error occurred");
			}
		}

	}
}
