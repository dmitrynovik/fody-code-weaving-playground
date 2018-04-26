using System;
using MethodTimer;

namespace FodyExample
{
    class Program
    {
        static int Main()
        {
            Console.WriteLine("Testing Fody.MethodTimer");
            RunTimedTask();

            Console.WriteLine("Press any key to exit");
            Console.Read();
            return 0;
        }

        [Time]
        private static void RunTimedTask(int until = int.MaxValue >> 2)
        {
            for (int i = 0; i < until; ++i) { }
        }
    }
}
