using System;
using System.Collections.Generic;

namespace Fields
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

	public class Customer
	{
		public int Id;
		public string Name;
		public List<Order> Orders = new List<Order> (); // 2  We initialize it here as an alternative

		//public Customer()
		//{
		//	// 1  Method to initialize a list
		//	Orders = new List<Order>();
		//}

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

	public class Order
	{
		//Code
	}

}
