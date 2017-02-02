using System;

namespace Indexers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Indexers
			// If you have a class that has a structure like Array, List or dictionary

			var cookie = new HttpCookie();
			cookie["name"] = "Bernat";
			Console.WriteLine(cookie["name"]);
		}
	}
}
