// Interfaces and Polymorphism

using System;
using System.Collections.Generic;

namespace Interfaces5
{
	public class VideoEncoder
	{
		private List<INotificationChannel> _notificationChannels;

		public VideoEncoder() // ctor
		{
			_notificationChannels = new List<INotificationChannel>();
		}

		public void Encode(Video video)
		{
			// Video Logic

			foreach (var channel in _notificationChannels)
				channel.Send(new Message());

		}

	}
}
