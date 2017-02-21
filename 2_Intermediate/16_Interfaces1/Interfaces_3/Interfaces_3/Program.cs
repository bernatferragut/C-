// Interfaces and Extensability

using System;

namespace Interfaces_3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

	public class DbMigrator
	{
		public void Migrate()
		{
			Console.WriteLine("Migration started at {0}", DateTime.Now);
			Console.WriteLine("Migration finished at {0}", DateTime.Now);
		}
	}
}
