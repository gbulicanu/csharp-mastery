using System;

namespace Exercise1
{
    public class Stopwatch
    {
        private bool started;
        private DateTime startedAt;
        private DateTime stoppedAt;
        private TimeSpan accumulatedTime = TimeSpan.Zero;

        public void Start()
        {
            if (started)
            {
                throw new InvalidOperationException("Already started.");
            }
            startedAt = DateTime.Now;
            started = true;
        }

        public void Stop()
        {
            stoppedAt = DateTime.Now;
            accumulatedTime += stoppedAt - startedAt;
            started = false;
        }

        public TimeSpan Duration
        {
            get
            {
                return started
                    ? DateTime.Now - startedAt
                    : accumulatedTime;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Stopwatch started ...");
            Console.WriteLine("Press 's' key - to stop, 'a' to start again, or 'q' to display duration and quit.");
            while (true)
            {
                var key = Console.ReadKey(true);
                try
                {
                    if (key.KeyChar == 's')
                    {
                        stopwatch.Stop();
                    }
                    else if (key.KeyChar == 'a')
                    {
                        stopwatch.Start();
                    }
                    else if (key.KeyChar == 'q')
                    {
                        break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Duration is: {0}", stopwatch.Duration);
        }
    }
}
