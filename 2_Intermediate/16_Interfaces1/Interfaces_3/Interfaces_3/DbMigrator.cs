using System;

namespace Interfaces_3
{
	public class DbMigrator
	{
		private readonly ILogger _logger;

		public DbMigrator(ILogger logger) // Injection dependency
		{
			_logger = logger;
		}

		public void Migrate()
		{
			Console.WriteLine("Migration started at {0}", DateTime.Now);
			Console.WriteLine("Migration finished at {0}", DateTime.Now);
		}
	}
}
