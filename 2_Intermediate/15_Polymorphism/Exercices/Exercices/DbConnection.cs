using System;

namespace Exercices
{
	public abstract class DbConnection
	{
		private string _connectionString;

		public string ConnectionString 
		{
			set
			{
				if (ConnectionString == null || ConnectionString.Length == 0)
				{
					throw new NullReferenceException("The string is empty or null");
				}
				_connectionString = value;
			}

			get
			{
				return _connectionString;
			}
		}

		private TimeSpan TimeOut { get; set; }

		public DbConnection(){}

		public DbConnection(string connectionString)
		{
			_connectionString = connectionString;
		}

		public abstract void OpenConnection();
		public abstract void CloseConnection();
	}
}
