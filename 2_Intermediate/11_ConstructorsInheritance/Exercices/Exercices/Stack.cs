using System;

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
		//Methods
		public void Push(Object object)
		{
			Console.WriteLine(" Pushin Element In ");
		}

		public void Pop()
		{
			Console.WriteLine(" Poping Element Out ");
		}

		public void Clear()
		{
			Console.WriteLine(" Clear the whole List ");
		}
	}

}
