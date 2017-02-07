using System;

// HAS A relationship ( Car has an engine )
// Flexibility
// Loosely coupled
// the Related Class is simply a private field

namespace Composition
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Console.WriteLine("Hello World!");

			var dbMigrator = new DbMigrator( new Logger()); //  Technique 1 We pass a new object

			var logger = new Logger();
			var myInstaller = new Installer(logger);

			dbMigrator.Migrate();

			myInstaller.Install();
		}
	}

}
