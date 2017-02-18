using System;

namespace Interfaces2
{
	public class OrderProcessor
	{
		private readonly IShippingCalculator _shippingCalculator;

		public OrderProcessor(IShippingCalculator shippingCalculator) // We are referencing an interface
		{
			_shippingCalculator = shippingCalculator;
		}

		public void Processor(Order order)
		{
			if (order.IsShipped) // def programming
				throw new InvalidOperationException("The order is already processed");
			
			order.Shippment = new Shippment; // object creation 
			{
				Cost = _shippingCalculator.CalculatorShipping(order),
				ShippingDate = DateTime.Today.AddDays(1)
			};
		}
	}
}
