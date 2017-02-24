using System;
using System.Collections.Generic;

namespace Exercices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var workflowengine = new WorkFlowEngine();

			workflowengine.workFlowActivities.Add(new WorkFlow1());
			workflowengine.workFlowActivities.Add(new WorkFlow2());

			workflowengine.Run();
	}
}
