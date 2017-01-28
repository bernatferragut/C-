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
		// The Oders field without a ctor will be always initialized to an empty list
		//List<Order> Orders = new List<Order>();

		// Readonly to make sure that field is only initialized once
		readonly List<Order> Orders = new List<Order>();

		public Customer()
		{
			// Initialize Order method 1
			//Orders = new List<Order>();
	
		}

}
