using System;

namespace FodyExample
{
    class Program
    {
        static int Main()
        {
            Console.WriteLine("Testing Fody.MethodTimer");
            Timed.RunTimedTask();

            Console.WriteLine("Press any key to exit");
            Console.Read();
            return 0;
        }
    }
}
