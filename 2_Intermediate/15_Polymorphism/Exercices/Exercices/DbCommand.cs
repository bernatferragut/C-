using System;

namespace Exercices
{
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

		public DbCommand() { } // ctor 1

		public DbCommand(DbConnection dbConnection, string Instruction) // ctor 2
		{
			_dbConnection = dbConnection;
			_instruction = Instruction;
		}

		public void Execute()
		{
			// Open the connection > Inherited from Connection Type

			// Run the instruction 
			Console.WriteLine(Instruction);

			// Close the connection >  Inherited from Connection Type

		}
	}
}
