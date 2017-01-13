﻿using System;
using System.Text;

namespace _Strings2
{
	public class SBOperations
	{
		//It's a mutable string without a bunch of methods
		//StringBuilder Manipulations
		//Not searching methods
		//More efficient to manioulate strings than the string method

		public static void Operations()
		{
			var builder = new StringBuilder("Hello");
			//Add
			builder.Append('=', 10);
			builder.AppendLine();
			builder.Append("Header");
			builder.AppendLine();
			builder.Append('=', 10);

			//Replace
			builder.Replace('=', '+');
			//Remove
			builder.Remove(0, 10);
			//Insert
			builder.Insert(0, new string('-', 10));
			Console.WriteLine(builder);
			//Indexer


		}
	}
}
