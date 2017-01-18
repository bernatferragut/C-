using System;
using System.IO;

namespace _Files1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Copy
			//File.Copy("c:\\temp\\myfile.jpeg", "d:\\temp\\myfile.jpeg", true);
			File.Copy(@"c:\temp\myfile.jpeg", @"d:\temp\myfile.jpeg", true);
			// verbatim string
		}
	}
}
