using System;
using System.Collections.Generic;

namespace Fields
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var customer1 = new Customer(121);
			customer1.Orders.Add(new Order());
			customer1.Orders.Add(new Order());

			Console.WriteLine(customer1.Orders.Count);
		}
	}

}
