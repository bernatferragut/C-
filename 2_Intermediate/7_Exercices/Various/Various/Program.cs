using System;

namespace Various
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// SW instance creation
			var mySW = new SW2();
			mySW.Start();

			// SO instance creaion
			var mySO = new StackOverflow(Message);
			mySO.DeleteMessge(Message);
		}
	}
}
