using System;

namespace Amazon
{
	public class Customer
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public void Promote() //  should be encapsulated
		{
			Console.WriteLine("Promote Logic changed");

			var calculator = new Ratecalculator();
			var rating = calculator.Calculate(this);
		}
	}
}
