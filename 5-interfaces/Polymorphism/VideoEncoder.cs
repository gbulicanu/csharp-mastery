using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> notificationChannels;

        public VideoEncoder()
        {
            this.notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video encoding logic
            // ...

            foreach (var channel in this.notificationChannels)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel notificationChannel)
        {
            this.notificationChannels.Add(notificationChannel);
        }
    }
}