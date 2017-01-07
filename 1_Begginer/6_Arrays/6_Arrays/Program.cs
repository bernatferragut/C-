using System;

namespace _Arrays
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = new int[] { 3, 4, 56, 98, 123, 23 };

			//Length
			Console.WriteLine(numbers.Length);

			//IndexOf()

			Console.WriteLine(Array.IndexOf(numbers,98));

			//Clear() Setting int to 0 bool to false and string to null

			Array.Clear(numbers, 3, 2);

			Console.WriteLine("Effect of clear: ");

			foreach(int number in numbers)
				Console.WriteLine(number);

			//Copy()

			var otherNumbers = new int[] { 99, 99 };

			Array.Copy(otherNumbers, numbers, 2);

			Console.WriteLine("Effect of copy: ");
			foreach( var n in numbers)
				Console.WriteLine(n);

			//Sort()

			Array.Sort(numbers);

			Console.WriteLine("Effect of sort: ");
			foreach(var n in numbers)
				Console.WriteLine(n);

			//Reverse()

			Array.Reverse(numbers);

			Console.WriteLine("Effect of Reverse: ");
			foreach(var n in numbers)
				Console.WriteLine(n);

		}
	}
}
