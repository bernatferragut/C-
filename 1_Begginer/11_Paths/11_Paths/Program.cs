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

			//FileName
			var myFileName = Path.GetFileName(path);
			Console.WriteLine("File Name: " + myFileName);

			//FileNameWithoutExtension
			var myFileNameWE = Path.GetFileNameWithoutExtension(path);
			Console.WriteLine("File Name Without Extension: " + myFileNameWE);


		}
	}
}
