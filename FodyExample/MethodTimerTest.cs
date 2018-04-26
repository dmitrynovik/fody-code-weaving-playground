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
        private static void RunTimedTask(int until = 100000000)
        {
            for (int i = 0; i < until; ++i) { }
        }
    }
}
