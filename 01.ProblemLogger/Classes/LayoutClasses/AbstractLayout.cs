namespace _01.ProblemLogger.Classes.LayoutClasses
{
    using System;
    using System.Text;
    using Interfaces;
    using Enums;
    using Classes.ValidatorClasses;

    public abstract class AbstractLayout : ILayout
    {
        public AbstractLayout()
        {
            
        }

        public abstract string FormatLogString(ReportLevel reportLevel, string logMessage);

        protected string ReportLevelAsString(ReportLevel reportLevel)
        {
            switch (reportLevel)
            {
                case ReportLevel.Info:
                    {
                        return "Info";
                    }
                case ReportLevel.Warning:
                    {
                        return "Warning";
                    }
                case ReportLevel.Error:
                    {
                        return "Error";
                    }
                case ReportLevel.Critical:
                    {
                        return "Critical";
                    }
                case ReportLevel.Fatal:
                    {
                        return "Fatal";
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException("Unrecognised Report Level");
                    }
            }
        }
    }
}
