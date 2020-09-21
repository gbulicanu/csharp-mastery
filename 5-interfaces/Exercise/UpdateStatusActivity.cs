using System;

namespace Exercise
{
    public class UpdateStatusActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Change the status of the video record in the database to 'Processing'");
        }
    }
}