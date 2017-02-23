// Interfaces and Polymorphism

using System;

namespace Interfaces5
{
	public class VideoEncoder
	{
		private readonly MailService _mailService; // prop

		public VideoEncoder() // ctor
		{
			_mailService = new MailService();
		}

		public void Encode(Video video)
		{
			// Video Logic
			_mailService.Send(new Mail());
		}
	}
}
