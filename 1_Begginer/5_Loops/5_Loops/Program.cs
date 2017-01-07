﻿using System;

namespace _Loops
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Program1();
			//Program2();
			//Program3();
			//Program4();
			Program5();
		}

		//1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with 
		//no remainder.Display the count on the console.

		public static void Program1()
		{
			for ( var i = 0;  i <= 100; i++)
			{
				if (i % 3 == 0)
					Console.WriteLine (i);
			}
		}

		//2- Write a program and continuously ask the user to enter a number or "ok" to exit.
		//Calculate the sum of all the previously entered numbers and display it on the console.

		public static void Program2()
		{
			var sum = 0;
			while (true)
			{
				Console.Write("Enter a number (or 'ok' to exit): ");
				var input = Console.ReadLine();

				if (input.ToLower() == "ok")
					break;

				sum += Convert.ToInt32(input);
			}
			Console.WriteLine("Sum of all numbers is: " + sum);
		}

		//3- Write a program and ask the user to enter a number.Compute the factorial of the number 
		//and print it on the console.For example, if the user enters 5, the program should calculate 
		//5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

		public void Program3()
		{
			Console.Write("Enter a number: ");
			var number = Convert.ToInt32(Console.ReadLine());

			var factorial = 1;
			for (var i = 1; i <= number; i++)
				factorial *= i;

			Console.WriteLine("{0}! = {1}", number, factorial);
		}

		//4- Write a program that picks a random number between 1 and 10. 
		//Give the user 4 chances to guess the number.If the user guesses the number, 
		//display “You won"; otherwise, display “You lost". 
		//(To make sure the program is behaving correctly, you can display the secret number 
		//on the console first.)

		public static void Program4()
		{
			var randomNumber = new Random();
			var rndm = randomNumber.Next(1, 10);

			var chances = 4;

			while (chances > 0)
			{
				Console.WriteLine("Write a number between 1 and 10: ");
				var number = Convert.ToInt32(Console.ReadLine());

				if (number == rndm)
				{
					Console.WriteLine("You won");
				}
				else
				{
					Console.WriteLine("try again");
				}
				chances -= 1;
			}
			Console.WriteLine("you lost");
		}

		//5- Write a program and ask the user to enter a series of numbers separated by comma.
		//Find the maximum of the numbers and display it on the console.
		//For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

		public void Program5()
		{
			Console.Write("Enter comma separated numbers: ");
			var input = Console.ReadLine();

			var numbers = input.Split(',');

			// Assume the first number is the max 
			var max = Convert.ToInt32(numbers[0]);

			foreach (var str in numbers)
			{
				var number = Convert.ToInt32(str);
				if (number > max)
					max = number;
			}

			Console.WriteLine("Max is " + max);

		}
}
