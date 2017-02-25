using System;
using System.Collections.Generic;

namespace Revisited
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var workflow = new Workflow();
			workflow.Add(new Task1());
			workflow.Add(new Task2());

			var myWorkflowEngine = new WorflowEngine();
			myWorkflowEngine.Run(workflow);
		}
	}
}
