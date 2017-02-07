using System;

// HAS A relationship ( Car has an engine )
// Flexibility
// Loosely coupled
// the Related Class is simply a private field

namespace Composition
{

	public class Installer
	{
		readonly Logger _logger;

		public Installer(Logger logger) //  We inject at birth the specific class we want
		{
			this._logger = logger;
		}

		public void Install()
		{
			_logger.Log("We are installing the application ");
		}
	}

}
