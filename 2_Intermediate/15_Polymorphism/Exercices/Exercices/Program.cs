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
			var mySqlConnection = new SqlConnection();
			mySqlConnection.OpenConnection();

			var myOracleConnection = new OracleConnection();
			myOracleConnection.OpenConnection();
		}
	}
}
