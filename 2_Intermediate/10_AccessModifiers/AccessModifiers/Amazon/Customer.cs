using System;

namespace Amazon
{

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
		// avoid Protected

		private int CalculateRating() // this method should not be available outside > private // not use protected
		{
			return 0;
		}
	}
}
