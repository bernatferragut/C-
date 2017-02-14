using System;

namespace AbstractClasses
{
	public abstract class Shape
	{
		public int Width { get;set; }
		public int Height { get; set; }

		public abstract void Draw();

		public void Copy()
		{
			Console.WriteLine("Copy Shape into ClipBoard");
		}

		public void Select()
		{
			Console.WriteLine("Select the Shape");
		}
	}
}
