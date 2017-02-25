using System;
using System.Collections.Generic;

namespace Revisited
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

	public interface ITask
	{
		void Execute();
	}

	public class Task1 : ITask
	{
		public void Execute()
		{
			Console.WriteLine("Task1 implementation");
		}
	}

	public class Task2 : ITask
	{
		public void Execute()
		{
			Console.WriteLine("Task2 implementation");
		}
	}

	public interface IWorkFlow
	{
		void Add(ITask task);
		void Remove(ITask task);
	}

	public class Workflow : IWorkFlow
	{
		private readonly List<ITask> _tasks;

		public Workflow()
		{
			_tasks = new List<ITask>();
		}

		public void Add(ITask task)
		{
			Console.WriteLine("Adding some Task");
		}

		public void Remove(ITask task)
		{
			Console.WriteLine("Removing some Task");
		}
	}

}
