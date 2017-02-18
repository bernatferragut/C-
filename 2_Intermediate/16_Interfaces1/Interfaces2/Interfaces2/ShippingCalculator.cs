using System;

namespace Interfaces2
{
	public interface IShippingCalculator // Interface
	{
		float CalculateShipping(Order order); // is calling the CalculateShipping Method from ShippingCalculator
	}

	public class ShippingCalculator : IShippingCalculator // this class implements that Interface
	{
		public float CalculateShipping(Order order)
		{
			if (order.TotalPrice < 30)
				return order.TotalPrice * .1f;

			return 0;
		}
	}
}
