using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            stopWatch.Start();
            stopWatch.Stop();
            Console.WriteLine($"Duration :{stopWatch.duration}");
        }
    }
}
