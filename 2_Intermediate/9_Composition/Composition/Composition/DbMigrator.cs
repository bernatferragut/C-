using System;

// HAS A relationship ( Car has an engine )
// Flexibility
// Loosely coupled
// the Related Class is simply a private field

namespace Composition
{

	public class DbMigrator
	{
		private readonly Logger _logger;

		// ctor

		public DbMigrator(Logger logger)
		{
			this._logger = logger;
		}

		// Method

		public void Migrate()
		{
			_logger.Log("We are migrating...");
		}
	}
}
