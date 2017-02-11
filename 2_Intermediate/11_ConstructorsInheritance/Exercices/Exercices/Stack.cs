using System;
using System.Collections.Generic;

namespace Exercices
{

	// Design a Stack = Storing a List of Elements in a LIFO (Last In First Out)
	// Design a class called Stack with three Methods:
	//
	// 1.  void Push(Object object)
	// Stores the give object on top of the stack
	// if 'null' passed > throw Invalid Operation Exception
	//
	// 2. Object Pop() 
	// Removes the object at the top of the stack and returns it
	//if  stack is 'empty'  > throw Invalid Operation Exception
	//
	// 3. Clear()

	// Removes all objects from the stack

	//Should be used like this
	// var stack = new Stack(); stack.Push(1); stack.Push(2); stack.Push(3);
	// Console.WriteLine(stack.Pop()); Console.WriteLine(stack.Pop()); Console.WriteLine(stack.Pop());

	public class Stack
	{
		//prop
		public List<object> myList = new List<object>();


		//Methods
		public void Push(object obj)
		{

			if (myList.Count == null)
			{
				//throw Exception("Invalid Operation Exception");
				Console.WriteLine("Invalid Operation Exception");
			}
			//Console.WriteLine(" Pushin Element In ");
			myList.Add(Convert.ToInt32(obj));
		}

		public object Pop()
		{
			if (myList.Count == 0)
			{
				//throw Exception("Invalid Operation Exception");
				Console.WriteLine("Invalid Operation Exception");
			}		
			//Console.WriteLine(" Poping Element Out ");
			var removed = myList.Remove(myList.Count - 1);
			return removed;
		}

		public void Clear()
		{
			//Console.WriteLine(" Clear the whole List ");
			myList.Clear();
		}
	}
}
