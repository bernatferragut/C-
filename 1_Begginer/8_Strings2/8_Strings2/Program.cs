using System;
using System.Collections.Generic;

namespace _Strings2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var sentence = "This is going to be a really really really really really really long text";
			var summary = SummarizeText(sentence, 100);
			Console.WriteLine(summary);

		}

		//We create a function that holds all the logic
		static string SummarizeText (string text, int maxLength = 20) 
		{
			if (text.Length < maxLength)
				return text;

			//sentence.Substring(0, maxNumber);
			var words = text.Split(' ');
			var totalChar = 0;
			var summaryWords = new List<string>();

			foreach (var word in words)
			{
				summaryWords.Add(word);

				totalChar += words.Length + 1;
				if (totalChar > maxLength)
					break;
			}

			return String.Join(" ", summaryWords) + "...";
		}
	}
}
