using System;
using System.Collections.Generic;

namespace Exercices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var workflowengine = new WorkFlowEngine();

			workflowengine.RegisterActivities(new WorkFlow1());
			workflowengine.RegisterActivities(new WorkFlow2());

			workflowengine.Run();
		}
	}
}
