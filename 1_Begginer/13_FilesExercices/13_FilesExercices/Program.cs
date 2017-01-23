using System;
using System.IO;
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

	//2 - Write a program that reads a text file and displays the longest word in the file.

	// Are you familiar with dictionaries? 
	//A better approach to keep track of the count of each word is to use a dictionary. 
	//With a dictionary, you get fast lookups. So you don't need these nested loops to find them and count them.
	//You need to iterate over the words, and for each word, look it up in the dictionary 
	//and increase its count by 1.
	// Then, you loop over all dictionary and find the words with the the highest repetitions.
	// I probably need to remove this exercise here as it's a bit too complicated for the basics 
	// course. Give me some time to design another similar but simpler exercise.

	//var MyDict = new Dictionary< int Key, string Value> ();
	public static class Exercise2
	{
		public static void Solution1()
		{
			Console.WriteLine(" Exercise 2 Solution");
		}
	}
}
