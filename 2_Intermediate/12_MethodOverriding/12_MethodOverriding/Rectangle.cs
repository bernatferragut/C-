using System;
using System.Collections.Generic;

namespace _MethodOverriding
{
	public class Rectangle : Shape
	{
		public override void Draw()
		{
			//base.Draw();
			Console.WriteLine(" Draw a Rectangle");
		}
	}
	
}
