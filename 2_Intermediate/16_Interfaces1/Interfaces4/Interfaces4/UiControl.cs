// Interfaces IS NOT Inheritance
using System;

namespace Interfaces4
{

	public class UiControl
	{
		public string Id { get;set; }
		public int Size { get; set; }
		//public Position TopLeft { get; set; }

		public virtual void Draw()
		{
		}

		public void Focus()
		{
			Console.WriteLine("Received Focus");
		}
	}
	
}
