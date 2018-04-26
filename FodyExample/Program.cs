using System;
using Anotar.NLog;
using MethodTimer;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace FodyExample
{
    class Program
    {
        static int Main()
        {
            MethodTimer();
            Anotar();
            Done();
            return 0;
        }

        private static void MethodTimer()
        {
            Console.WriteLine("Testing Fody.MethodTimer");
            RunTimedTask();
        }

        [Time]
        private static void RunTimedTask(int until = int.MaxValue >> 2)
        {
            for (int i = 0; i < until; ++i) { }
        }

        private static void Anotar()
        {
            var config = new LoggingConfiguration();
            var consoleTarget = new ColoredConsoleTarget();
            config.AddTarget("console", consoleTarget);
            var rule = new LoggingRule("*", LogLevel.Debug, consoleTarget);
            config.LoggingRules.Add(rule);
            LogManager.Configuration = config;

            Console.WriteLine("\nTesting Anotar");
            LogTo.Info("Dmitry");
        }

        private static void Done()
        {
            Console.WriteLine("Press any key to exit");
            Console.Read();
        }
    }
}
