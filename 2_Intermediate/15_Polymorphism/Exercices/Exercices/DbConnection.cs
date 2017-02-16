using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Exercices
{

	public abstract class DbConnection
	{
		public String ConnectionString { get; set; }
		private TimeSpan TimeOut { get; set; }

		public DbConnection(){}

		public DbConnection(string ConnString)
		{
			this.ConnectionString = ConnString;
		}

		public abstract void OpenConnection();
		public abstract void CloseConnection();
	}
	
}
