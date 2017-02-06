using System;

namespace _Inheritance
{
	public class PresentationObject
	{
		// Props
		public int Width{ get; set; }

		public int Hieght{ get; set; }

		//Methods
		public void Copy()
		{
			Console.WriteLine("Object Copied to clipboard");
		}

		public void Paste()
		{
			Console.WriteLine("Object was Pasted to file");
		}
	}
}
