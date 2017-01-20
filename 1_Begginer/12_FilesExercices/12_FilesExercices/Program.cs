using System;
using System.IO;

namespace _FilesExercices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Exercise1.Solution1();
			//Exercise1.Solution2();
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
	public static class Exercise2
	{
		public static void Solution2()
		{

		}
	}
}
