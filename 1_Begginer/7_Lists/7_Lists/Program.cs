using System;
using System.Collections.Generic; // Here we include the list class

namespace _Lists
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = new List<int>() { 9, 945, 45, 34349, 34 };
			numbers.Add(9);
			numbers.AddRange(new int[] { 5, 6, 7 });

			foreach( var n in numbers)
				Console.WriteLine(n);

			var i = numbers.IndexOf(45); //  search from the begining
			Console.WriteLine("The index of 45 id: " + i);

			var g = numbers.LastIndexOf(9); // search from the last
			Console.WriteLine("The last index of 9 id: " + g);

			Console.WriteLine("Count : " + numbers.Count);

			numbers.Remove(9); // a 'specific' number


			for (int l = 0; l < numbers.Count; l++)
			{
				if (numbers[l] == 9)
				{
					numbers.Remove(numbers[l]);
				}
			}

			foreach (var number in numbers)
				Console.WriteLine(number);

			numbers.Clear();
			Console.WriteLine("Last Count : " + numbers.Count);
		}
	}
}
