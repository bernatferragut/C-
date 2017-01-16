using System;
using System.Collections.Generic;

namespace _StringsExercices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Exercise1();
			//Exercise2();
			//Exercise3();
			//Exercise4();
			Exercise5();
		}

		//1- Write a program and ask the user to enter a few numbers separated by a hyphen.
		//Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" 
		//or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
		public static void Exercise1()
		{
			Console.Write("Enter a few numbers (eg 1-2-3-4): ");
			var input = Console.ReadLine();

			var numbers = new List<int>();
			foreach (var number in input.Split('-'))
				numbers.Add(Convert.ToInt32(number));

			numbers.Sort();

			var isConsecutive = true;
			for (var i = 1; i < numbers.Count; i++)
			{
				if (numbers[i] != numbers[i - 1] + 1)//if you add one to a two consecutive numbers thry should be equal
				{
					isConsecutive = false;
					break;
				}
			}

			var message = isConsecutive ? "Consecutive" : "Not Consecutive";
			Console.WriteLine(message);
		}

	}
}
