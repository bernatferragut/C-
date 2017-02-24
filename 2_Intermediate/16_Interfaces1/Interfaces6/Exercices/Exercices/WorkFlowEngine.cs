using System;
using System.Collections.Generic;

namespace Exercices
{
	public class WorkFlowEngine
	{
		private List<ITask> _workFlowActivities;

		public WorkFlowEngine()
		{
			_workFlowActivities = new List<ITask>();
		}

		public void RegisterActivities(ITask activity)
		{
			_workFlowActivities.Add(activity);
		}

		public void Run()
		{
			foreach (var activity in _workFlowActivities)
				activity.Execute();
		}
	}
}