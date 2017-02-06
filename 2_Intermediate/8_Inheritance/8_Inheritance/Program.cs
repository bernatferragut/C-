using System;

// Inheritamce 'IS A' relationship - Common 'behaviours' and 'porperties' are inherited between classes
// Code reuse
// Polymorphism
// Parent or Super Class - vs - Child or Sub Class

namespace _Inheritance
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var text = new Text();

			// We inherited from Text Class AND from PresentationObject and the Main Object
			text.Width = 100;
			text.Hieght = 50;
			text.Copy();
		}

	}
}
