using System;
using System.Collections.Generic;

namespace Exercices
{
	public class WorkFlowEngine
	{
		private List<IActivity> _workFlowActivities;

		public WorkFlowEngine()
		{
			_workFlowActivities = new List<IActivity>();
		}

		public void RegisterActivities(IActivity activity)
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