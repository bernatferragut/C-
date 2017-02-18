using System;

namespace Interfaces2
{
	public class Order
	{
		public int Id { get;set; }
		public DateTime DateTimePlaced { get; set; }
		public Shippment Shippment { get; set; }
		public float TotalPrice { get; set; }

		public bool IsShipped
		{
			get { return Shippment != null; }
		}
	}
}
