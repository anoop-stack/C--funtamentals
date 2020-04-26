using System;

namespace Exercise_1
{
    class StopWatch
    {
        public TimeSpan duration
        {
            get
            {
                var time = stop - start;

                return time;
            }
        }
        private DateTime start;

        private DateTime stop;

        public void Stop()
        {
            stop = DateTime.Now.AddHours(1);
        }

        public void Start()
        {
            start = DateTime.Now;
        }
    }
}
