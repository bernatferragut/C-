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

		public void Promote() //  should be encapsulated
		{
			var rating = CalculateRating();
			if (rating == 0)
			{
				Console.WriteLine("Promoted to Level 1");
			}
			else
			{
				Console.WriteLine("Promoted to Level 2");
			}
		}

		public int CalculateRating() // this method should not be available outside
		{
			return 0;
		}
	}
}
