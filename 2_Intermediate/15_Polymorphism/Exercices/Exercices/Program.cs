using System;

namespace Exercices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string message = " My Message ";

			var mySqlConnection = new SqlConnection(message);
			mySqlConnection.OpenConnection();

			var myOracleConnection = new OracleConnection(message);
			myOracleConnection.OpenConnection();
		}
	}

	// Class DbCommand that executes database instructions

	public class DbCommand
	{
		private DbConnection _dbConnection; // prop

		public DbConnection dbConnection // prop logic
		{
			get
			{
				return _dbConnection;
			}
			set
			{
				if (dbConnection == null)
				{
					throw new NullReferenceException("The string is Null");
				}
				_dbConnection = value;
			}
		}

		public DbCommand(DbConnection dbConnection)
		{
			_dbConnection = dbConnection;
		}
	}

}


