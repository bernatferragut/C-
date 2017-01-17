﻿using System;
using System.Collections.Generic;

namespace _Prodefural
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			{
				Console.Write("Enter a few numbers (eg 1-2-3-4): ");
				var input = Console.ReadLine();

				var numbers = new List<int>();
				foreach (var number in input.Split('-'))
					numbers.Add(Convert.ToInt32(number));

				numbers.Sort();

				var message = ConsecutiveNumber.ConsecutiveNum(numbers);

				Console.WriteLine(message);
			}
		}
	}
}
