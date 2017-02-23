// Interfaces and Polymorphism

using System;

namespace Interfaces5
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var encode = new VideoEncoder();
			encode.Encode(new Video());
		}
	}
}
