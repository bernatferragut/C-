using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace _FilesExercices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Exercise1.Solution1();
			Exercise2.Solution1();
		}
	}

	//1 - Write a program that reads a text file and displays the number of words.
	public static class Exercise1
	{
		public static void Solution1()
		{
			var path = @"/Users/bernatferragut/Desktop/files/Abulafia.cs";

			if (File.Exists(path))
			{
				// Read and show the file.
				var input = File.ReadAllText(path);

				//Using WordCount
				var number = WordCount(input);

				Console.WriteLine("Number of words: {0}", number);
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		//the function for counting words
		public static int WordCount(string input)
		{
			//Calculating the number of words
			int counter = 0;
			foreach (var word in (input.Split()))
			{
				counter++;
			}
			return counter;
		}
	}

	//2 - Write a program that reads a text file and displays 'the most repeated word' in the file.
	// input String
	// Splitted to List1
	// Loop over the words
	// foreach repeated word Add to Dictio
	// Find most repeated word in discionnary

	//var MyDict = new Dictionary< int Key, string Value> ();
	public static class Exercise2
	{
		public static void Solution1()
		{
			var path = @"/Users/bernatferragut/Desktop/files/Abulafia.cs";

			if (File.Exists(path))
			{
				// Read and show the file.
				var input = File.ReadAllText(path);

				//Using MostRepeatedWord
				var repeatedWord = MostRepeatedWord(input);
				foreach (var keyValuePair in  repeatedWord)
					Console.WriteLine("The Most Repeated word is : {0}", keyValuePair);
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		//the function for MostRepeatedWord
		public static Dictionary<string, int> MostRepeatedWord(string input)
		{
			//Calculating the MostRepeatedWord

			//MyDict
			var myDict = new Dictionary<string, int> ();
			//MyList
			var myList = new List<string>();
			//input
			var inputWords = input.Split();

			var count = 1;

			for (var i = 0; i < inputWords.Length; i++)
			{
				myList.Add(inputWords[i]);

				if (myList.Contains(inputWords[i]))
				{
					myDict.Add(inputWords[i], count++);
				}
				else
				{
					myDict.Add(inputWords[i], count);
				}
			}
			return myDict;
		}
	}
}
