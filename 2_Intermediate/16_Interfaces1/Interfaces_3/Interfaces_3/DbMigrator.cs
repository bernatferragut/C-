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
			_logger.LogInfo("Migration started at {0}" + DateTime.Now);

			_logger.LogError("Migration finished at {0}" + DateTime.Now);
		}
	}
}
