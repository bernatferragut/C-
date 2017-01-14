using System;
using System.Collections.Generic;

namespace _StringsExercices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Exercise1();
			//Exercise2();
			//Exercise3();
			//Exercise4();
			//Exercise5();
		}

		//1- Write a program and ask the user to enter a few numbers separated by a hyphen.
		//Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" 
		//or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
		public static void Exercise1()
		{
			Console.Write("Enter a few numbers (eg 1-2-3-4): ");
			var input = Console.ReadLine();

			var numbers = new List<int>();
			foreach (var number in input.Split('-'))
				numbers.Add(Convert.ToInt32(number));

			numbers.Sort();

			var isConsecutive = true;
			for (var i = 1; i < numbers.Count; i++)
			{
				if (numbers[i] != numbers[i - 1] + 1)
				{
					isConsecutive = false;
					break;
				}
			}

			var message = isConsecutive ? "Consecutive" : "Not Consecutive";
			Console.WriteLine(message);
		}

		//2- Write a program and ask the user to enter a few numbers separated by a hyphen.
		//If the user simply presses Enter, without supplying an input, exit immediately; 
		//otherwise, check to see if there are duplicates.If so, display "Duplicate" on the console.
		public static void Exercice2()
		{

		}


		//3- Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00). 
		//A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; 
		//otherwise, display "Invalid Time". If the user doesn't provide any values, 
		//consider it as invalid time. 
		public static void Exercice3()
		{

		}


		//4- Write a program and ask the user to enter a few words separated by a space.
		//Use the words to create a variable name with PascalCase.For example, if the user types: 
		//"number of students", display "NumberOfStudents". 
		//Make sure that the program is not dependent on the input.
		//So, if the user types "NUMBER OF STUDENTS", the program should still display 
		//"NumberOfStudents".
		public static void Exercice4()
		{

		}


		//5- Write a program and ask the user to enter an English word. 
		//Count the number of vowels (a, e, o, u, i) in the word.
		//So, if the user enters "inadequate", the program should display 6 on the console.
		public static void Exercice5()
		{

		}
	}
}
