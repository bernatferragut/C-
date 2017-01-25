using System;


namespace ClassesA
{
	// Constructors
	public class Customer
	{
		public int Id;
		public string Name;

		//Default or parameter less ctor
		public Customer()
		{
		}

		public Customer(int id)
		{
			this.Id = id;
		}

		public Customer(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}
	}
}
