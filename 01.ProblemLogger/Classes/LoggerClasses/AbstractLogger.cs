namespace _01.ProblemLogger.Classes.LoggerClasses
{
    using System;
    using Interfaces;
    using Enums;
    using Classes.ValidatorClasses;

    public abstract class AbstractLogger : ILogger
    {
        private IAppender[] appenders;

        public AbstractLogger(params IAppender[] appender)
        {
            this.Appenders = appender;
        }

        public IAppender[] Appenders
        {
            get
            {
                return this.appenders;
            }
            private set
            {
                this.appenders = value;
            }
        }

        public void AddAppender(IAppender appender)
        {
            int size = this.Appenders.Length;
            int newSize = size + 1;

            IAppender[] tmp = new IAppender[newSize];
            Array.Copy(this.Appenders, 0, tmp, 0, size);

            this.Appenders = tmp;

            this.Appenders[newSize - 1] = appender;
        }

        public virtual void Info(string infoMessage)
        {
            this.LogMessage(ReportLevel.Info, infoMessage);
        }

        public virtual void Warning(string warningMessage)
        {
            this.LogMessage(ReportLevel.Warning, warningMessage);
        }

        public virtual void Error(string errorMessage)
        {
            this.LogMessage(ReportLevel.Error, errorMessage);
        }

        public virtual void Critical(string criticalMessage)
        {
            this.LogMessage(ReportLevel.Critical, criticalMessage);
        }

        public virtual void Fatal(string fatalMessage)
        {
            this.LogMessage(ReportLevel.Fatal, fatalMessage);
        }

        protected void LogMessage(ReportLevel reportLevel, string message)
        {
            DataValidator.ValidateMessageString(message, "Failed To Log Message - Log String Cannot Be Null Or Empty");

            foreach (IAppender appender in this.Appenders)
            {
                appender.Append(reportLevel, message);
            }
        }
    }
}
