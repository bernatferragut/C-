using System;
using System.IO;
using System.Collections.Generic;

namespace Methods_1
{

	public class Calculator
	{
		//1.
		//public int Add(int n1, int n2) { }
		//public int Add(int n1, int n2, int n3) { }
		//public int Add(int n1, int n2, int n3, int n4) { }

		//2.
		// using an Array to Oveload

		//public int Add(int[] numbers) { }

		//3.
		// a simle way using: PARAMS Modifier

		//public int Add2(params int[] numbers) { }

		public int Add(params int[] numbers)
		{
			var sum = 0;
			foreach (var number in numbers)
			{
				sum += number;
			}
			return sum;
		}
	}
}
