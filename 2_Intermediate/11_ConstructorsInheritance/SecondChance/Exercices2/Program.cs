using System;

namespace Exercices2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var myStack = new Stack("Bernat");

			myStack.Push(12);
			myStack.Push(13);
			myStack.Push(14);

			Console.WriteLine(myStack.Pop());
			Console.WriteLine(myStack.Pop());
			Console.WriteLine(myStack.Pop());
		}
	}
}
