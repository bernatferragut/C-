using System;

namespace Exercices
{
	public class OracleConnection : DbConnection
	{
		public OracleConnection (string connectionString) : base(connectionString){ } // new ctor

		public override void OpenConnection()
		{
			Console.WriteLine("Openning Oracle Connection...");
		}

		public override void CloseConnection()
		{
			Console.WriteLine("Closing Oracle Connection...");
		}
	}
}
