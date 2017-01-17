using System;
using System.Collections.Generic;

namespace _Procedurals
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter time: ");
			var input = Console.ReadLine();

			if (String.IsNullOrWhiteSpace(input))
			{
				Console.WriteLine("Invalid Time");
				return;
			}

			var components = input.Split(':');
			if (components.Length != 2)
			{
				Console.WriteLine("Invalid Time");
				return;
			}
			//
			var result = TimeComparison(components);
			if (result == true)
				Console.WriteLine("Valid Time");

			Console.WriteLine("Invalid Time");

		}

		public static bool TimeComparison(string[] components)
		{
			try
			{
				var hour = Convert.ToInt32(components[0]);
				var minute = Convert.ToInt32(components[1]);

				if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
					return true;
				else
					return false;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
