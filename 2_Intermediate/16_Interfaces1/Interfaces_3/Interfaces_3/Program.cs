using System;
using System.IO;

namespace Interfaces_3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var dbMigrator = new DbMigrator(new ConsoleLogger());
			dbMigrator.Migrate();
		}
	}
}
