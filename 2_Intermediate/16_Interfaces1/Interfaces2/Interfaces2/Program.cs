using System;

namespace Interfaces2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var orderProcessor = new OrderProcessor(new ShippingCalculator());
			var order = new Order(DateTime Placed = DateTime.Now, Total Price = 100f);
			orderProcessor.Process(order);
		}
	}
}
