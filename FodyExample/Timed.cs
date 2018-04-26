using MethodTimer;

namespace FodyExample
{
    public static class Timed
    {
        [Time]
        public static void RunTimedTask(int until = int.MaxValue >> 2)
        {
            for (int i = 0; i < until; ++i) { }
        }
    }
}
