using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

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
}
