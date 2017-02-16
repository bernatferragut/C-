using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Exercices
{

	public class SqlConnection : DbConnection
	{
		public override void OpenConnection()
		{
			Console.WriteLine("Openning Connection...");
		}

		public override void CloseConnection()
		{
			Console.WriteLine("Closing Connection...");
		}
	}
	
}
