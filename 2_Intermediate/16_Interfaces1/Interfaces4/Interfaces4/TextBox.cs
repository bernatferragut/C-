// Interfaces IS NOT Inheritance
using System;

namespace Interfaces4
{

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
