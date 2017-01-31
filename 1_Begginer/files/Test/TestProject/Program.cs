using System;
using System.IO;

namespace _Files1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//FILES > Provides static methods

			File.Copy(@"c:\temp\myfile.jpeg", @"d:\temp\myfile.jpeg", true);
			// verbatim string

			//Delete
			File.Delete(path);

			//Exists

			if (File.Exists(@"c:\temp\myfile.jpeg")
			{
				//do something
			}
			    
			//Read
			var content = File.ReadAllText(path);

			//FILESINFO > Provides Instance Methods

			var fileInfo = new FileInfo(path);
			//Copy
			fileInfo.CopyTo("...");
			fileInfo.Delete();

			//Exists is a methof

			if (fileInfo.Exists)
			{
				// do something
			}

			fileInfo.OpenRead("different way of openeing a file");

		}
	}
}
