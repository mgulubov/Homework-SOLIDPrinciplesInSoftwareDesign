namespace _01.ProblemLogger.Interfaces
{
    public interface ILogger : IInfoLogger, IWarningLogger, IErrorLogger, ICriticalLogger, IFatalLogger
    {
        IAppender[] Appenders { get; }
        void AddAppender(IAppender appender);
    }
}
