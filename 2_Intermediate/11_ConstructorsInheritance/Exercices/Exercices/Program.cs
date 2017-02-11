using System;

namespace Exercices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var stack = new Stack();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);

			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());

			stack.Clear();
		}
	}
}
