using System;

namespace Exercices
{
	public class SqlConnection : DbConnection
	{
		public SqlConnection(string connectionString) : base (connectionString) { } // new ctor that inherits from base

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
