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

		private string _instruction; // prop
		public string Instruction // prop logic
		{
			get
			{
				return _instruction;
			}
			set
			{
				if (string.IsNullOrEmpty(Instruction))
				{
					throw new NullReferenceException("Null Reference Exception");
				}
				_instruction = value;
			}
		}

		public DbCommand(DbConnection dbConnection, string Instruction) // ctor
		{
			_dbConnection = dbConnection;
			_instruction = Instruction;
		}
	}

}


