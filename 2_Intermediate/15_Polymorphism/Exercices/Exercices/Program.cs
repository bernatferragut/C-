using System;
using System.Text;

namespace Exercices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string message = "String message for dbConnection";
			string sqlLanguage = "This is a SQL Language Command";
			string oracleLanguage = "This is an Oracle Language Command";

			Console.WriteLine("#################");

			var mySqlConnection = new SqlConnection(message); // we need to pass a message
			mySqlConnection.OpenConnection();
			mySqlConnection.CloseConnection();

			var myOracleConnection = new OracleConnection(message); // we need to pass a message
			myOracleConnection.OpenConnection();
			myOracleConnection.CloseConnection();

			Console.WriteLine("#################");

			var myDbCommandA = new DbCommand(mySqlConnection, sqlLanguage); // we need to pass a message and an object
			myDbCommandA.dbConnection.OpenConnection();
			myDbCommandA.Execute();
			myDbCommandA.dbConnection.CloseConnection();

			var myDbCommandB = new DbCommand(myOracleConnection, oracleLanguage); // we need to pass a message and an object
			myDbCommandB.dbConnection.OpenConnection();
			myDbCommandB.Execute();
			myDbCommandB.dbConnection.CloseConnection();

			Console.WriteLine("#################");
		}
	}
}


