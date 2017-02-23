using System;
namespace Interfaces5
{

	public class SmsNotificationchannel : INotificationChannel
	{
		public void Send(Message message)
		{
			Console.WriteLine("Sending SMS...");
		}
	}
}
