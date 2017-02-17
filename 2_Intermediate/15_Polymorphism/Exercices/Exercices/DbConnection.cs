using System;

namespace Exercices
{
	public abstract class DbConnection
	{
		private TimeSpan TimeOut { get; set; } // prop

		private string _connectionString; // prop

		public string ConnectionString // prop logic
		{
			get
			{
				return _connectionString;
			}

			set
			{
				if (string.IsNullOrEmpty(ConnectionString))
				{
					throw new NullReferenceException("The string is empty or null");
				}
				_connectionString = value;
			}
		}

		protected DbConnection() { }  // ctor 1

		protected DbConnection(string connectionString)  // ctor 2
		{
			_connectionString = connectionString;
		}

		public abstract void OpenConnection(); // method 1
		public abstract void CloseConnection(); // method 1
	}
}
