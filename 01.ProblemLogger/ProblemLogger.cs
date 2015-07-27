namespace _01.ProblemLogger
{
    using System;
    using Interfaces;
    using Classes.AppenderClasses;
    using Classes.LayoutClasses;
    using Classes.LoggerClasses;

    class ProblemLogger
    {
        static void Main(string[] args)
        {
            ILayout simpleLayout = new SimpleLayout();
            IAppender consoleAppender = new ConsoleAppender(simpleLayout);
            ILogger logger = new Logger(consoleAppender);

            logger.Error("Error parsing JSON");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));

            Console.WriteLine(new string('-', 20));

            //We create a second Appender and add it to the existing ILogger object
            IFileAppender fileAppender = new FileAppender(simpleLayout);
            fileAppender.File = "log.txt";

            logger.AddAppender(fileAppender);

            logger.Fatal("mscorlib.dll does not respond");
            logger.Critical("No connection string found in App.config");

            Console.WriteLine(new string('-', 20));

            //We set the new XML Layout on each Appender that the Logger object uses
            foreach (IAppender appender in logger.Appenders)
            {
                appender.Layout = new XmlLayout();
            }

            logger.Fatal("mscorlib.dll does not respond");
            logger.Critical("No connection string found in App.config");

            Console.WriteLine(new string('-', 20));

            //We set the Report Level Minimum at Error
            foreach (IAppender appender in logger.Appenders)
            {
                appender.ReportLevelMinimum = Enums.ReportLevel.Error;
            }

            logger.Info("Everything seems fine");
            logger.Warning("Warning: ping is too high - disconnect imminent");
            logger.Error("Error parsing request");
            logger.Critical("No connection string found in App.config");
            logger.Fatal("mscorlib.dll does not respond");

            Console.WriteLine(new string('-', 20));
        }
    }
}
