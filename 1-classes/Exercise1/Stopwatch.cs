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
}
