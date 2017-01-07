using System;

namespace _TypeConversions
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			try
			{
				//string number = "1234";
				//byte i = Convert.ToByte(number);
				//Console.WriteLine(i);
				string str = "true";
				bool b = Convert.ToBoolean(str);
				Console.WriteLine(b);
			}
			catch (Exception ex)
			{
				Console.WriteLine(" Can not convert to Bool");
			}
		}
	}
}
