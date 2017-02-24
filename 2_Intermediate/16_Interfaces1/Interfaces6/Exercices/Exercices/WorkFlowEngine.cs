using System;
using System.Collections.Generic;

namespace Exercices
{
	public class WorkFlowEngine
	{
		public List<IActivity> workFlowActivities;

		public WorkFlowEngine()
		{
			var _workFlowActivities = new List<IActivity>();
		}

		public void Run(List<IActivity>  workflowList)
		{
			foreach (var activity in workFlowActivities)
				activity.Execute();
		}
	}
}
