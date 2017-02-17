﻿using System;
using System.Text;

namespace Exercices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string message = "dbConnection";
			string sqlLanguage = "This is a SQL Language Command";
			string oracleLanguage = "This is an Oracle Language Command";

			Console.WriteLine("#################");

			var mySqlConnection = new SqlConnection(message);
			mySqlConnection.OpenConnection();
			mySqlConnection.CloseConnection();

			var myOracleConnection = new OracleConnection(message);
			myOracleConnection.OpenConnection();
			myOracleConnection.CloseConnection();

			Console.WriteLine("#################");

			var myDbCommandA = new DbCommand(mySqlConnection, sqlLanguage);
			myDbCommandA.dbConnection.OpenConnection();
			myDbCommandA.Execute();
			myDbCommandA.dbConnection.CloseConnection();

			var myDbCommandB = new DbCommand(myOracleConnection, oracleLanguage);
			myDbCommandB.dbConnection.OpenConnection();
			myDbCommandB.Execute();
			myDbCommandB.dbConnection.CloseConnection();

			Console.WriteLine("#################");
		}
	}
}


