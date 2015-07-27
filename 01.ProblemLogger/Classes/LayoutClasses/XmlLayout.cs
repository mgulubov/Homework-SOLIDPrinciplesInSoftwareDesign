namespace _01.ProblemLogger.Classes.LayoutClasses
{
    using System;
    using Enums;

    public class XmlLayout : AbstractLayout
    {
        public XmlLayout()
        {

        }

        public override string FormatLogString(ReportLevel reportLevel, string logMessage)
        {
            string logString = string.Format(
                "<log>\r\n" +
                "\t<date>{0}</date>{1}" +
                "\t<level>{2}</level>{1}" +
                "\t<message>{3}</message>\n" +
                "</log>",
                DateTime.Now,
                Environment.NewLine,
                this.ReportLevelAsString(reportLevel),
                logMessage
                );

            return logString;
        }
    }
}
