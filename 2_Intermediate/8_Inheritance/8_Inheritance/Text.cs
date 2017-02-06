using System;

// Inheritamce 'IS A' relationship - Common 'behaviours' and 'porperties' are inherited
// Code reuse
// Polymorphism
// Parent or Super Class - vs - Child or Sub Class

namespace _Inheritance
{

	public class Text : PresentationObject
	{
		// Props
		public int FontSize { get; set; }
		public string FontName { get; set; }

		// Methods
		public void AddHyperLink(string url)
		{
			Console.WriteLine("We added a link to" + url);
		}
	}
}
