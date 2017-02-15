using System;

namespace Exercices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

	// 'Connection to Access a Database' - We must build this Class object
	// Things in Common: 
	// 1. They have a connection String
	// 2. They can be opened
	// 3. They can be closed
	// 4. They may have a Timeout attribute
	// Base Class: DbConnection
	// Has 2 Attributes: 
	// A. String ConnectionString - Has to be passe in the ctor class + Null or empty scenarios + throw an exception
	// B. TimeSpan TimeOut
	// C. 2 Methods: OpenConnection + CloseConnection ( Abstract ). Implementation to derived classes
	// Derived Classes: SqlConnection + OracleConnection ( Do implementation with CW )
}
