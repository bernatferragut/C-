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
			var path = @"/Users/bernatferragut/Desktop/files/Abulafia.txt ";
			//@"Master:\temp\myfile.jpeg";


			if (File.Exists(path))
			{
				// Read and show the file.
				var readFile = File.OpenRead(path);
				Console.WriteLine(readFile);

			}
			else
			{
				Console.WriteLine("File does not exist");
			}
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
