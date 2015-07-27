namespace _01.ProblemLogger.Classes.ComparerClasses
{
    using System;
    using Enums;
    using Interfaces;

    public class StandartReportLevelComparer : AbstractReportLevelComparer
    {
        public static readonly StandartReportLevelComparer REPORT_LEVEL_COMPARER = new StandartReportLevelComparer();

        private StandartReportLevelComparer()
        {
            //Singleton
        }

        protected override int ConvertReportLevelToInt(ReportLevel reportLevel)
        {
            switch (reportLevel)
            {
                case ReportLevel.Info:
                    {
                        return 0;
                    }
                case ReportLevel.Warning:
                    {
                        return 1;
                    }
                case ReportLevel.Error:
                    {
                        return 2;
                    }
                case ReportLevel.Critical:
                    {
                        return 3;
                    }
                case ReportLevel.Fatal:
                    {
                        return 4;
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException("Cannot Convert Report Level To Int - Unrecognized Report Level");
                    }
            }
        }
    }
}
