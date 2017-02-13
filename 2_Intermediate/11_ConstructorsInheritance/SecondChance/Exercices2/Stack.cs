using System;
using System.Collections.Generic;

namespace Exercices2
{
	class Stack
	{
		//prop
		public string Name { get; } // value that we pass or get
		private readonly List<object> _stackList = new List<object>(); // reference

		//ctor
		public Stack(string name)
		{
			this.Name = name;
		}

		//methods
		public void Push(object obj)
		{
			if (obj == null) throw new ArgumentNullException(nameof(obj));
			_stackList.Add(obj);
		}

		public object Pop()
		{
			if (_stackList.Count == 0) throw new IndexOutOfRangeException("The stack is empty");
			var topOfList = _stackList[_stackList.Count - 1];
			_stackList.Remove(_stackList[_stackList.Count - 1]);
			return topOfList;
		}

		public void Clear()
		{
			_stackList.Clear();
		}
	}
}
