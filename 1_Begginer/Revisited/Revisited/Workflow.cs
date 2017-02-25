using System;
using System.Collections.Generic;

namespace Revisited
{

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

		public void Run()
		{
			foreach (var task in _tasks)
				task.Execute();
		}
	}

}
