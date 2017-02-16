using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Exercices
{

	public class OracleConnection : DbConnection
	{
		public OracleConnection (string connectionString) : base(connectionString){ } // new ctor

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
