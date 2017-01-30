using System;

namespace AccMod
{
	// 1.Public
	// 2.Private
	// 3.Protected
	// 4.Internal
	// 5.Protected Internal
	// A way to control access to a class and or its memebers ti improve robustness

	// A. ENCAPSULATION or INFORMATION HIDING

	class MainClass
	{
		public static void Main(string[] args)
		{
			var pb = new PersonB();
			pb.SetBirth(new DateTime().Date);
		}
	}

	public class PersonA
	{
		private string _name; //  we cannot access the name

		public void SetName(string name) // we can only access through the method 
		{
			if (!String.IsNullOrWhiteSpace(name)) // we include a condition
			{
				this._name = name;
			}
		}

		public string GetName()
		{
			return _name; // private fields
		}
	}

	public class PersonB
	{
		private DateTime _birthdate;

		public void SetBirth(DateTime birth)
		{
			this._birthdate = birth;
		}

		public DateTime GetBirth()
		{
			return _birthdate;
		}
	}

}
