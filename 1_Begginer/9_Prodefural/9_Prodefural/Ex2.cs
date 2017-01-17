//Ex2

using System;
using System.Collections.Generic;

namespace _Procedural
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Ex2
			Console.Write("Enter a few numbers (eg 1-2-3-4): ");
			var input = Console.ReadLine();

			if (String.IsNullOrWhiteSpace(input))
				return;

			var numbers = new List<int>();
			foreach (var number in input.Split('-'))
				numbers.Add(Convert.ToInt32(number));

			var includeDuplicates = HasDuplicate(numbers);

			if (includeDuplicates)
				Console.WriteLine("Duplicate");

			Console.WriteLine("NotDuplicate");
		}

		public static bool HasDuplicate(List<int> numbers)
		{
			var uniques = new List<int>();

			foreach (var number in numbers)
			{
				if (!uniques.Contains(number))
					uniques.Add(number);
				else
				{
					return true;
				}
			}
			return false;
		}

	}
}