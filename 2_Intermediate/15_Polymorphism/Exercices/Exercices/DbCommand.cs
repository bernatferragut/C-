using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Exercices
{

	public class DbCommand
	{
		public DbConnection ConnectionN
		{
			get 
			{
				return ConnectionN; 
			}

			set
			{
				if (ConnectionN == null)
				{
					throw new NullReferenceException("None Connection passed");
				}

				ConnectionN = value;
			}
		}

		public DbCommand(DbConnection ConnectionN) { }
	}


}
