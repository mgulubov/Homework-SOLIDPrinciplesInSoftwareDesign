namespace _01.ProblemLogger.Classes.ComparerClasses
{
    using Enums;
    using Interfaces;

    public abstract class AbstractReportLevelComparer : IReportLevelComparer
    {
        public AbstractReportLevelComparer()
        {

        }

        protected abstract int ConvertReportLevelToInt(ReportLevel reportLevel);

        public int Compare(ReportLevel levelToCompare, ReportLevel minimumLevel)
        {
            int levelToCompareAsInt = this.ConvertReportLevelToInt(levelToCompare);
            int minimumLevelAsInt = this.ConvertReportLevelToInt(minimumLevel);

            if (levelToCompare > minimumLevel)
            {
                return 1;
            }
            else if (levelToCompare < minimumLevel)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
