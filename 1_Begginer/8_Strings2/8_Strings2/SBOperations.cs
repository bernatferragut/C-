﻿using System;
using System.Text;

namespace _Strings2
{
	public class SBOperations
	{
		// It's a mutable string without a bunch of methods
		//StringBuilder Manipulations

		public static void Operations()
		{
			var builder = new StringBuilder();

			builder.Append('=', 10);
			builder.AppendLine();
			builder.Append("Header");
			Console.WriteLine(builder);
		}
	}
}
