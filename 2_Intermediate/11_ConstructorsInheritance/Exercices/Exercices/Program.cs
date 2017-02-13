using System;

namespace Exercices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var stack = new Stack("TestObject");

			Console.WriteLine($"{stack.Name} created.");

			//	stack.Push(null);
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);

			Console.WriteLine("\nPushed 1, 2 and 3 to the stack.");

			Console.WriteLine("\n");
			Console.WriteLine($"Removing {stack.Pop()} from the stack.");
			Console.WriteLine($"Removing {stack.Pop()} from the stack.");
			Console.WriteLine($"Removing {stack.Pop()} from the stack.");

			stack.Clear();

			Console.ReadKey();

			//	stack.Pop();
		}
	}
}
