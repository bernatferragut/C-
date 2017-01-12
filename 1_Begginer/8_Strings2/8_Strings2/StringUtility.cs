using System;
using System.Collections.Generic;

namespace _Strings2
{
	public class StringUtility
	{

		//We create a function that holds all the logic
		public static string SummarizeText(string text, int maxLength = 20)
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
