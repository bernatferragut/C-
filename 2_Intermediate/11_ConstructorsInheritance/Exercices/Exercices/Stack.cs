using System;
using System.Collections.Generic;

namespace Exercices
{
	public class Stack
	{
		public string Name { get; }
		private readonly List<object> _stack = new List<object>(); //  we initialize the list private with _stack

		public Stack(string name)
		{
			Name = name;
		}

		public void Push(object obj)
		{
			if (obj == null) throw new ArgumentNullException(nameof(obj));
			_stack.Add(obj);
		}

		public object Pop()
		{
			if (_stack.Count == 0) throw new IndexOutOfRangeException($"The stack '{Name}' is empty.");
			var topStack = _stack[_stack.Count - 1];
			_stack.Remove(_stack[_stack.Count - 1]);
			return topStack;
		}

		public void Clear()
		{
			_stack.Clear();
			Console.WriteLine($"\nStack cleared. There are {_stack.Count} elements in the object '{Name}'.\n");
		}
	}
}
