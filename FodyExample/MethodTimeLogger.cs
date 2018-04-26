using System;
using System.Reflection;

namespace FodyExample
{
    public static class MethodTimeLogger
    {
        public static void Log(MethodBase methodBase, long milliseconds) =>
            Console.WriteLine($"{methodBase} took {milliseconds}ms.");
    }
}
