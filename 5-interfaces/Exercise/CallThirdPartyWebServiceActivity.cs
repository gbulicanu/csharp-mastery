using System;

namespace Exercise
{
    public class CallThirdPartyWebServiceActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Call a web service provided by a third-party " +
                "video encoding service to tell them you have a video ready for encoding.");
        }
    }
}