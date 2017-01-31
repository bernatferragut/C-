using System;

namespace Props
{
	public class Person3
	{
		// PROPERTIES ( Auto Implemented Propertites )
		public DateTime birthdate { get; set; }
		public String Bernat { get; set; }

		//CONSTRUCTORS
		public Person3()
		{
			//Code
		}

		// CALCULATED PROPERTIES or prperties with logic 
		public int Age
		{
			get //  we include some logic cause years are based on birthdate
			{
				var timeSpan = DateTime.Today - Birthdate;
				var years = timeSpan.Days / 360;
				return years;
			}
		}

		//METHODS
		public DateTime Ages(DateTime birthdate)
		{
			//Code
		}
	}
}
