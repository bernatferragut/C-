using System;
using System.Collections.Generic;

namespace Fields
{

	public class Customer
	{
		public int Id;
		public string Name;
		readonly public List<Order> Orders = new List<Order> (); // 2  We initialize it here as an alternative

		// Readonly can only used in the initialozation field or in the ctor

		public Customer(int id)
		{
			this.Id = id;
		}

		public Customer(int id, string name)
			:this(id)
		{
			this.Name = name;
		}

		public void Promote(){ }

	}

}
