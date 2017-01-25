using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _FilesExercices
{

	// C# program that removes duplicate words

	class MainClass
	{
		public static void Main(string[] args)
		{
			var path = @"/Users/bernatferragut/Desktop/files/Abulafia.cs";

			var myText = File.ReadAllText(path);

			//Console.WriteLine(myText);

			Console.WriteLine(RemovesDuplicatWords(myText));
		}

		public static string RemovesDuplicatWords(string myText)
		{
			//1
			//Keeps track words found in dictionary
			var myDict = new Dictionary<string, bool>();

			//2
			//Build up String into this StringBuilder
			var StrBuilder = new StringBuilder();

			//3
			//Split the input and handle spaces and punctuations
			var cleanedMyText = myText.Split(new char[] { ' ', ',', ';', '.' }, StringSplitOptions.RemoveEmptyEntries);

			//4
			//Loop over each word
			foreach (var word in cleanedMyText)
			{
				//5
				//to lower
				var cleanedToLower = word.ToLower();

				//6
				//If we have not yet found the word append it to the result
				if (!myDict.ContainsKey(cleanedToLower))
				{
					StrBuilder.Append(cleanedToLower).Append(' ');
					myDict.Add(cleanedToLower, true);
				}
			}
			//7
			//Return the Duplicate words removed
			return StrBuilder.ToString().Trim();
		}
	}
}
