using System;

namespace ClassesA
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var Customer = new Customer();
			//Customer.Id = 1;
			//Customer.Name = "Ber";

			Console.WriteLine(Customer.Id);
			Console.WriteLine(Customer.Name);
		}
	}


}
