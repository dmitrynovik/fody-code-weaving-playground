using System;
using Anotar.NLog;
using NLog;
using NLog.Config;
using NLog.Targets;
using Xunit;

namespace FodyExample
{
    public class AnotarTest
    {
        [Fact]
        public void Anotar()
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
    }
}
