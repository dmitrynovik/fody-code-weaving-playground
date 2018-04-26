using MethodTimer;

namespace FodyExample
{
    class Program
    {
        static int Main(string[] args)
        {
            RunTimedTask();
            return 0;
        }

        [Time]
        private static void RunTimedTask(int until = int.MaxValue)
        {
            for (int i = 0; i < until; ++i) { }
        }
    }
}
