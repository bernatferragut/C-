using System;
using System.Collections.Generic;

namespace _Prodefural
{
	public class ConsecutiveNumber
	{
		public static bool ConsecutiveNum(List<int> numbers)

		// Consecutive Number calculations Method

		{
			for (var i = 1; i < numbers.Count; i++)
			{
				if (numbers[i] != numbers[i - 1] + 1)
				{
					return false; ;
				}
			}
			return true;
		}
	}
}
