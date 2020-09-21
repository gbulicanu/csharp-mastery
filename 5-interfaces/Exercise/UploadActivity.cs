using System;

namespace Exercise
{
    public class UploadActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Upload a video to a cloud storage.");
        }
    }
}