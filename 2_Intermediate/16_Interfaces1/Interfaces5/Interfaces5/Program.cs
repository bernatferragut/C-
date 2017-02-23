// Interfaces and Polymorphism
// OOP Open Close Principle >  Open for extension but Close for modification

using System;

namespace Interfaces5
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var encoder = new VideoEncoder();
			encoder.RegisterNotificationChannel(new MailNotificationChannel());
			encoder.RegisterNotificationChannel(new SmsNotificationchannel());
			encoder.Encode(new Video());
		}
	}
}
