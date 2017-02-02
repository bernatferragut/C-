using System;
using System.Collections.Generic;

namespace Indexers
{

	public class HttpCookie
	{
		private readonly Dictionary<string, string> _dicionary;

		public HttpCookie()
		{
			_dicionary = new Dictionary<string, string>();
		}

		public string this[string key]
		{
			get { return _dicionary[key]; }
			set { _dicionary[key] = value; }
		}
	}
}
