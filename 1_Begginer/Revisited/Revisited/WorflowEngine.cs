using System;
using System.Collections.Generic;

namespace Revisited
{
	public class WorflowEngine
	{
		public void Run(IWorkFlow workflow)
		{
			foreach (ITask task in workflow.GetTasks())
				task.Execute();
		}
	}
}
