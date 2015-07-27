namespace _01.ProblemLogger.Classes.LayoutClasses
{
    using System;
    using System.Text;
    using Enums;

    public class SimpleLayout : AbstractLayout
    {
        public SimpleLayout()
        {

        }

        public override string FormatLogString(ReportLevel reportLevel, string logMessage)
        {
            string logString = string.Format("{0} - {1} - {2}",
                DateTime.Now, this.ReportLevelAsString(reportLevel), logMessage);

            return logString;
        }
    }
}
