using System;

namespace ClassesA
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");

			var customer = new Customer(1,"Ber");

			Console.WriteLine(customer.Id);
			Console.WriteLine(customer.Name);
		
		}
	}

	


}
