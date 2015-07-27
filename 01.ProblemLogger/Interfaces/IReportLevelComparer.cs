namespace _01.ProblemLogger.Interfaces
{
    using Enums;

    public interface IReportLevelComparer
    {
        int Compare(ReportLevel levelToCompare, ReportLevel minimumLevel);
    }
}
