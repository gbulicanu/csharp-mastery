using System;

namespace Polymorphism
{
    public class VideoEncoder
    {
        private readonly MailService mailService;

        public VideoEncoder()
        {
            this.mailService = new MailService();
        }
        public void Encode(Video video)
        {
            // Video encoding logic
            // ...

            this.mailService.Send(new Mail());
        }
    }
}