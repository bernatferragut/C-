using System;
using System.Collections.Generic;


namespace ClassesA
{
	// Constructors
	public class Customer
	{
		public int Id;
		public string Name;
		public List<Order> Orders; // Empty List Initialization always!

		//Default or parameter less ctor
		public Customer()
		{
			Orders = new List<Order>();
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

		//If we have different fields in initialization

	}
}
