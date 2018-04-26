using System;
using MethodTimer;
using Xunit;

namespace FodyExample
{    
    public class MethodTimerTest
    {
        [Fact]
        public void MethodTimer()
        {
            Console.WriteLine("Testing Fody.MethodTimer");
            RunTimedTask();
        }

        [Time]
        private static void RunTimedTask(int until = int.MaxValue >> 2)
        {
            for (int i = 0; i < until; ++i) { }
        }
    }
}
