using System;

namespace Strings
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var myName = "Bernat Ferragut ";
			//Trim
			Console.WriteLine("Trim: '{0}'", myName.Trim());
			//ToUpper
			Console.WriteLine("ToUpper: '{0}'", myName.Trim().ToUpper()); // chaining methods
			//Split1
			var index = myName.IndexOf(' ');
			var firstName = myName.Substring(0,index);
			var lastName = myName.Substring(index+1);
			Console.WriteLine("First Name: " + firstName);
			Console.WriteLine("Last Name: " + lastName);
			//Split2
			var names = myName.Split(' ');
			Console.WriteLine("First Name: "+ names[0]);
			Console.WriteLine("Last tName: "+ names[1]);
			//Replace
			myName.Replace("Bernat", "Bearnat");
			myName.Replace('B', 'b');
			//myName.Replace(' ','');//This is what Trim is

			Console.WriteLine(myName.Replace("Bernat", "Bearnat"));

			//####################################################

			//Validation
			if (String.IsNullOrEmpty(null))//null or "" empty string
			    Console.WriteLine("Invalid Message");

			if (String.IsNullOrWhiteSpace(" "))//null or "" empty string
				Console.WriteLine("Invalid Message");

			//Receive numbers
			var str = "42";
			var ageInt = Convert.ToByte(str);
			Console.WriteLine(ageInt);

			float price = 29.99f;
			var currency = price.ToString("C0");
			Console.WriteLine(currency);
		}
	}
}
