using System;

namespace _Strings2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var sentence = "This is going to be a really really really really really really long text";
			const int maxNumber = 20;

			if (sentence.Length < maxNumber)
				Console.WriteLine(sentence);
			else
			{
				//sentence.Substring(0, maxNumber);
			}

		}
	}
}
