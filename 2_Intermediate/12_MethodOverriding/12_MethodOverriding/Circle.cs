using System;
using System.Collections.Generic;

namespace _MethodOverriding
{
	public class Circle : Shape
	{
		public override void Draw()
		{
			//base.Draw();
			Console.WriteLine("Draw a Circle");
		}
	}
}
