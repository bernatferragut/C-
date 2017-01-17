using System;
using System.Collections.Generic;

namespace _Procedurals
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter a few words: ");
			var input = Console.ReadLine();


			var result = WordWithPascaleCase(input);
			Console.WriteLine(result);
		}

		//Option 1
		public static string WordWithPascaleCase(string input)
		{
			if (String.IsNullOrWhiteSpace(input))
			{
				return "";
			}

			var variableName = "";
			foreach (var word in input.Split(' '))
			{
				var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
				variableName += wordWithPascalCase;
			}
			return variableName;
			
		}

		// Option2
		public string GetVariableName(string input)
		{
			if (String.IsNullOrWhiteSpace(input))
				return "";

			var variableName = "";
			foreach (var word in input.Split(' '))
			{
				var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
				variableName += wordWithPascalCase;
			}

			return variableName;
		}
	}
}
