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

			Console.WriteLine(myText);

			//Console.WriteLine(RemovesDuplicatWords(myText));
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
			//


		}
	}
}
