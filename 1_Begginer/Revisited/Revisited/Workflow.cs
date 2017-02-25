using System;
using System.Collections.Generic;

namespace Revisited
{
	public class Workflow : IWorkFlow
	{
		private readonly List<ITask> _tasks; // prop : a List

		public Workflow()
		{
			_tasks = new List<ITask>(); // List initalization
		}

		public void Add(ITask task) // Method 1 implementing Iworkflow
		{
			_tasks.Add(task);
		}

		public void Remove(ITask task) // Method 2 implementing Iworkflow
		{
			_tasks.Remove(task);
		}

		public void Run()
		{
			foreach (var task in _tasks)
				task.Execute();
		}
	}
}
