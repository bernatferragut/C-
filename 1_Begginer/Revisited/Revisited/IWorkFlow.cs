using System;
using System.Collections.Generic;

namespace Revisited
{
	public interface IWorkFlow
	{
		void Add(ITask task);
		void Remove(ITask task);
	}

}
