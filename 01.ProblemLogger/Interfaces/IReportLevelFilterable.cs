namespace _01.ProblemLogger.Interfaces
{
    using Enums;

    public interface IReportLevelFilterable
    {
        ReportLevel ReportLevelMinimum { get; set; }
        IReportLevelComparer ReportLevelComparer { get; set; }
        bool ShouldPrint(ReportLevel reportLevel);
    }
}
