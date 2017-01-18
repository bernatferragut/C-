using System;
using System.IO;

namespace _Files1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//####FILES####
			var path = @"c:\temp\myfile.jpeg";

			//Copy
			File.Copy(@"c:\temp\myfile.jpeg", @"d:\temp\myfile.jpeg", true);
			// verbatim string

			//Delete
			File.Delete(path);

			//Exists

			//if (File.Exists(@"c:\temp\myfile.jpeg")
				//do something

				//Read

			var content = File.ReadAllText(path);

			//####FILESINFO####

			var fileInfo = new FileInfo(path);
			//Copy
			fileInfo.CopyTo("...");
			fileInfo.Delete();

		}
	}
}
