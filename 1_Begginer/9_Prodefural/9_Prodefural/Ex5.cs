using System;
using System.Collections.Generic;

namespace _Procedurals
{
	class MainClass
	{
		public static void Main(string[] args)
		{ 
			Console.Write("Enter a word: ");
			// Note the ToLower() here. This is used to count for both A and a. 
			var input = Console.ReadLine().ToLower();

			var result = IncludesVowels(input);

			if ( result == true)
				Console.WriteLine("Has vowels");

			Console.WriteLine("Does not have vowels");
		}

		public static bool IncludesVowels(string input)
		{
			var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
			var vowelsCount = 0;
			foreach (var character in input)
			{
				if (vowels.Contains(character))
					vowelsCount++;
					return true;
			}
			return false;
		}
	}
}
