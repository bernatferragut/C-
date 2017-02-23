using System;
namespace Interfaces5
{

	public class MailNotificationChannel : INotificationChannel
	{
		public void Send(Message message)
		{
			Console.WriteLine("Sending Mail...");
		}
	}
}
