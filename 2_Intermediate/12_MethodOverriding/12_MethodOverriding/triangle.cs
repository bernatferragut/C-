// Method Overriding
// Modifyinf the implementation of an inherited Method
// We need to encapsulate data and behaviour in one Class

using System;
using System.Collections.Generic;

namespace _MethodOverriding
{

	public class Triangle : Shape
	{
		public override void Draw()
		{
			//base.Draw();
			Console.WriteLine("Draw a Triangle");
		}
	}
}
