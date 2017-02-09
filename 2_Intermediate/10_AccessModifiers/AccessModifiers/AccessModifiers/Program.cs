using System;

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

	public class Customer
	{
		public int Id
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public void Promote()
		{
			
		}
	}
}
