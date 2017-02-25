using System;
using System.Collections.Generic;

namespace Revisited
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var myWorkflow = new Workflow();
			myWorkflow.Add(new Task1());
			myWorkflow.Add(new Task2());

			myWorkflow.Run();
		}
	}
}
