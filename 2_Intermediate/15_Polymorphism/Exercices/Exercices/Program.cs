using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var dbconnection = new DbConnection();
		}
	}

	// 'Connection to Access a Database' - We must build this Class object
	// Things in Common: 
	// 1. They have a connection String
	// 2. They can be opened
	// 3. They can be closed
	// 4. They may have a Timeout attribute
	// Base Class: DbConnection
	// Has 2 Attributes: 
	// A. String ConnectionString - Has to be passed in the ctor class + Null or empty scenarios + throw an exception
	// B. TimeSpan TimeOut
	// C. 2 Methods: OpenConnection + CloseConnection ( Abstract ). Implementation to derived classes
	// Derived Classes: SqlConnection + OracleConnection ( Do implementation with CW )

	public abstract class DbConnection
	{
		public String ConnectionString { get; set; }
		private TimeSpan TimeOut { get; set; }

		public DbConnection() { }

		public DbConnection(String ConnString)
		{
			this.ConnectionString = ConnString;
		}

		public abstract void OpenConnection();
		public abstract void CloseConnection();
	}

	public class SqlConnection : DbConnection
	{
		public override void CloseConnection()
		{
			Console.WriteLine("Closing Connection...");
		}

		public override void OpenConnection()
		{
			Console.WriteLine("Openning Connection...");
		}
	}

	public class OracleConnection : DbConnection
	{
		public override void CloseConnection()
		{
			Console.WriteLine("Closing Connection...");
		}

		public override void OpenConnection()
		{
			Console.WriteLine("Openning Connection...");
		}
	}
}
