using System;

namespace Props
{

	// We can avhieve the same with a Property

	public class Person1
	{
		private DateTime _birthdate; // field

		public DateTime Birthdate // properties
		{
			get { return _birthdate; }
			set { _birthdate = value; }
		}
	}
		
}
