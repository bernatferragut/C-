using System;
using System.Collections.Generic;

namespace Exercices
{
	public class WorkFlowEngine
	{
		private List<IWorkflow> _workFlowActivities;

		public WorkFlowEngine()
		{
			_workFlowActivities = new List<IWorkflow>();
		}

		public void RegisterActivities(IWorkflow activity)
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