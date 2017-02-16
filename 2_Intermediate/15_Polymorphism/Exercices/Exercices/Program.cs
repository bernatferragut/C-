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
}


