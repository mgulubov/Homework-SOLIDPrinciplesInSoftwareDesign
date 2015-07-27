namespace _01.ProblemLogger.Classes.AppenderClasses
{
    using Interfaces;
    using Enums;
    using Classes.ValidatorClasses;
    using Classes.ComparerClasses;

    public abstract class AbstractAppender : IAppender
    {
        private ILayout layout;
        private ReportLevel reportLevelMinimum;
        private IReportLevelComparer reportLevelComparer;

        public AbstractAppender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevelMinimum = ReportLevel.Info;
            this.ReportLevelComparer = StandartReportLevelComparer.REPORT_LEVEL_COMPARER; //We use this as the default comparer
        }

        public ILayout Layout
        {
            get
            {
                return this.layout;
            }
            set
            {
                this.layout = value;
            }
        }

        public ReportLevel ReportLevelMinimum 
        {
            get
            {
                return this.reportLevelMinimum;
            }
            set
            {
                this.reportLevelMinimum = value;
            } 
        }

        public IReportLevelComparer ReportLevelComparer
        {
            get
            {
                return this.reportLevelComparer;
            }
            set
            {
                this.reportLevelComparer = value;
            }
        }

        protected abstract void WriteToOutput(string logMessage);

        public virtual void Append(ReportLevel reportLevel, string logMessage)
        {
            if (!this.ShouldPrint(reportLevel))
            {
                return;
            }

            string formattedLogMessage = this.Layout.FormatLogString(reportLevel, logMessage);

            this.WriteToOutput(formattedLogMessage);
        }

        public bool ShouldPrint(ReportLevel reportLevel) 
        {
            return this.ReportLevelComparer.Compare(reportLevel, this.ReportLevelMinimum) >= 0;
        }
    }
}
