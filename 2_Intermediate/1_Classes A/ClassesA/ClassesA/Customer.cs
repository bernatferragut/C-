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

		public Customer(int id) // Overload ctr
			: this()
		{
			this.Id = id;
		}

		public Customer(int id, string name) // Overload ctr
			: this(id) //  we use this to pass any other ctr field we ant to pass to, keep it to minimum
		{
			this.Name = name;
		}

		//If we have different fields in initialization

	}
}
