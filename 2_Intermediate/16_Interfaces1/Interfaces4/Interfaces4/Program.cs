// Interfaces IS NOT Inheritance

using System;

namespace Interfaces4
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

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

	public class TextBox : UiControl, IDraggable, IDroppable
	{
		public void Drag()
		{
			throw new NotImplementedException();
		}

		public void Drop()
		{
			throw new NotImplementedException();
		}
	}
}
