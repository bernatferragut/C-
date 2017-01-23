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
			//Exercise2.Solution2();
			Exercise3.Solution1();
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

	//1 - Write a program that reads a text file and displays the number of words.
	//public static class Exercise1B
	//{
		

	//	public static void Solution1()
	//	{
	//		var path = @"/Users/bernatferragut/Desktop/files/Abulafia.cs";

	//		Console.WriteLine("number of words:" + NumberofWords(path));
	//	}

	//	//the function for counting words
	//	public static int NumberofWords(string path)
	//	{
	//		char[] chars = { ' ', ',', '.', '?', '!', ';', ':', '\'', '-', '/', '=' };

	//		var text = File.ReadAllText(path).Replace("\r\n", " "); // return and end of line for whitespace

	//		var count = 0;
	//		for (var i = 0; i < text.Length - 1; i++)
	//		{
	//			if (!chars.Contains(text[i]) && chars.Contains(text[i + 1]))  // check for double,tripple whitespaces,comma etc  
	//			{
	//				count++;
	//			}
	//			return count;
	//		}
	//	}
	//}

	//2 - Write a program that reads a text file and displays the longest word in the file.
	public static class Exercise2
	{
		public static void Solution2()
		{
			var path = @"/Users/bernatferragut/Desktop/files/Abulafia.cs";

			if (File.Exists(path))
			{
				Console.WriteLine("File Exist");

				var myText = File.ReadAllText(path);
				var myWords = myText.Split();

				var numLetters = 0;

				for (var i = 0; i < myWords.Length; i++)
				{
					var num = myWords[i].Split();
					var len = num.Length;

					if (len > numLetters)
						numLetters = len;
				}

				Console.WriteLine("The longest word has: {0} Letters", numLetters);
			}
			else
			{
				Console.WriteLine("File does not Exist");
			}
		}
	}

	//1 - Write a program that reads a text file and displays the number of words.
	public static class Exercise3
	{


		public static void Solution1()
		{
			var path = @"/Users/bernatferragut/Desktop/files/Abulafia.cs";

			//Console.WriteLine("number of words:" + NumberofWords(path));
		}

		//the function for counting words
		//public static int NumberofWords(string path)
		//{
		//	char[] chars = { ' ', ',', '.', '?', '!', ';', ':', '\'', '-', '/', '=' };

		//	var text = File.ReadAllText(path).Replace("\r\n", " "); // return and end of line for whitespace

		//	var count = 0;
		//	for (var i = 0; i < text.Length - 1; i++)
		//	{
		//		if (!chars.Contains(text[i]) && chars.Contains(text[i + 1]))  // check for double,tripple whitespaces,comma etc  
		//		{
		//			count++;
		//		}
		//		else
		//		{
		//			return 0;
		//		}
		//		return count;
		//	}
		
				
		//}

		// Are you familiar with dictionaries? 
		//A better approach to keep track of the count of each word is to use a dictionary. 
		//With a dictionary, you get fast lookups. So you don't need these nested loops to find them and count them.
		//You need to iterate over the words, and for each word, look it up in the dictionary 
		//and increase its count by 1.
		// Then, you loop over all dictionary and find the words with the the highest repetitions.
		// I probably need to remove this exercise here as it's a bit too complicated for the basics 
		// course. Give me some time to design another similar but simpler exercise.

		//var MyDict = new Dictionary< int Key, string Value> ();
	}
}
