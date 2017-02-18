using System;

namespace Interfaces2
{
	public interface IShippingCalculator // Interface
	{
		
	}

	public class ShippingCalculator
	{
		public float CalculateShipping(Order order)
		{
			if (order.TotalPrice < 30)
				return order.TotalPrice * .1f;

			return 0;
		}
	}
}
