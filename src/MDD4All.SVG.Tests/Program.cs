/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using NLog;
using NLog.Config;
using NLog.Targets;
using System;

namespace MDD4All.SVG.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeLogging();

            //Test1 test1 = new Test1();
            Test2 test2 = new Test2();

            Console.ReadLine();
        }

        private static void InitializeLogging()
        {
            LoggingConfiguration loggingConfig = new LoggingConfiguration();

            ColoredConsoleTarget consoleTarget = new ColoredConsoleTarget("coloredConsole")
            {
                Layout = @"${date:format=yy/MM/dd HH\:mm\:ss} ${level} - ${message} ${exception}"
            };
            loggingConfig.AddTarget(consoleTarget);

            //FileTarget fileTarget = new FileTarget("target2")
            //{
            //    FileName = "d:/KAMCOS_SHell/logOutput.txt",
            //    Layout = "${message}",
            //    DeleteOldFileOnStartup = true
            //};
            //loggingConfig.AddTarget(fileTarget);



            //loggingConfig.AddRuleForOneLevel(LogLevel.Info, consoleTarget);
            loggingConfig.AddRuleForAllLevels(consoleTarget);
            //loggingConfig.AddRuleForAllLevels(fileTarget);

            LogManager.Configuration = loggingConfig;
        }
    }
}
