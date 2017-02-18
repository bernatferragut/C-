using System;

namespace Interfaces2
{
	public class OrderProcessor
	{
		private readonly ShippingCalculator _shippingCalculator;

		public OrderProcessor()
		{
			_shippingCalculator = new ShippingCalculator();
		}

		public void Processor(Order order)
		{
			if (order.IsShipped) // def programming
				throw new InvalidOperationException("The order is already processed");
			
			order.Shipment = new Shipment; // object creation 
			{
				Cost = _shippingCalculator.CalculatorShipping(order),
				ShippingDate = DateTime.Today.AddDays(1)
			};
		}
	}
}
