
using Amazon;

namespace AccessModifiers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var customer = new Customer();
			customer.Promote();
		}
	}

	public class GoldCustomer : Customer
	{
		public void OfferVoucher()
		{
			Console.WriteLine(" A Voucher has been Offered! ");
			this.Promote();
		}
	}
}
