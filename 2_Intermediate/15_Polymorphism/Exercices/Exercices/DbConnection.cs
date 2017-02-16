using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Exercices
{
	public abstract class DbConnection
	{
		public string ConnectionString { get; set; }
		private TimeSpan TimeOut { get; set; }

		public DbConnection(){}

		public DbConnection(string connectionString)
		{
			this.ConnectionString = connectionString;
		}

		public abstract void OpenConnection();
		public abstract void CloseConnection();
	}
}
