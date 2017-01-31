using System;

namespace Props
{

	public class Person
	{
		private DateTime _birthdate; // Declare as private

		public void SetBirth(DateTime Birthdate) // Setter
		{
			this._birthdate = Birthdate;
		}

		public DateTime SetBirth() // Getter
		{
			return _birthdate;
		}
	}
		
}
