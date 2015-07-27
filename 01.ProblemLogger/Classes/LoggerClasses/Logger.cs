namespace _01.ProblemLogger.Classes.LoggerClasses
{
    using Interfaces;

    public class Logger : AbstractLogger
    {
        public Logger(params IAppender[] appender)
            : base(appender)
        {

        }
    }
}
