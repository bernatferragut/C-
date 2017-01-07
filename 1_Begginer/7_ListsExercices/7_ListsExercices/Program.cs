﻿using System;
using System.Collections.Generic;

namespace _ListsExercices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Exercice1();
			Exercice2();
		}

		//1- When you post a message on Facebook, depending on the number of people who like 
		//your post, Facebook displays different information.

		//If no one likes your post, it doesn't display anything.
		//If only one person likes your post, it displays: [Friend's Name] likes your post.
		//If two people like your post, it displays: [Friend 1]
		//and[Friend 2] like your post.
		//If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number 
		//of Other People] others like your post.

		//Write a program and continuously ask the user to enter different names, until the user 
		//presses Enter (without supplying a name). Depending on the number of names provided, 
		//display a message based on the above pattern.

		public static void Exercice1()
		{
			var continual = true;
			var namesList = new List<string>();

			while (continual) //true
			{
				Console.WriteLine("Enter a name: ");
				var name = Console.ReadLine();

				if (name == "")
				{
					break;
				}
				else
				{
					namesList.Add(name);

					for (var n = 0; n < namesList.Count; n++) // names = 1
					{
						if (n == 1) // names = 2
						{
							Console.WriteLine("{0} : Like your Post", namesList[0]);
							Console.WriteLine("{0} : Like your Post", namesList[1]);
							Console.WriteLine("###################");
						}
						else if (n > 1) // names > 2
						{
							Console.WriteLine("{0} : Like your Post", namesList[0]);
							Console.WriteLine("{0} : Like your Post", namesList[1]);
							Console.WriteLine("{0} : Others Like your post", (namesList.Count) - 2);
							Console.WriteLine("###################");

						}
					}
				}
			}
		}

		//2- Write a program and ask the user to enter their name.Use an array to reverse 
		//the name and then store the result in a new string. Display the reversed name on 
		//the console.

		public static void Exercice2()
		{
			Console.Write("What's your name? ");
			var name = Console.ReadLine();

			var array = new char[name.Length];
			for (var i = name.Length; i > 0; i--)
				array[name.Length - i] = name[i - 1];

			var reversed = new string(array);
			Console.WriteLine("Reversed name: " + reversed);
		}

		//3- Write a program and ask the user to enter 5 numbers.If a number has been previously 
		//entered, display an error message and ask the user to re-try. Once the user successfully 
		//enters 5 unique numbers, sort them and display the result on the console.

		public static void Exercice3()
		{

		}

		//4- Write a program and ask the user to continuously enter a number or type "Quit" to 
		//exit. The list of numbers may include duplicates.Display the unique numbers that the 
		//user has entered.

		public static void Exercice4()
		{

		}

		//5- Write a program and ask the user to supply a list of comma separated numbers 
		//(e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display 
		//"Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers 
		//in the list.

		public static void Exercice5()
		{

		}
	}
}
