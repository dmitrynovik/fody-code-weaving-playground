using System;
using Anotar.NLog;
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
            Timed.RunTimedTask();
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
