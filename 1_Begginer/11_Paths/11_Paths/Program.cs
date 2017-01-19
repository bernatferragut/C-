using System;
using System.IO;

namespace _Paths
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var path = @"C:\Projects\CSharpFundamentals\myCSharpSolution.sln";

			//Classic Method
			//var dotIndex = path.IndexOf('.');
			//var extension = path.Substring(dotIndex);

			//Path Class
			var myExtension = Path.GetExtension(path);
			Console.WriteLine("Extension: " + myExtension);

		}
	}
}
