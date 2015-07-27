namespace _01.ProblemLogger.Interfaces
{
    using Enums;

    public interface IAppender : IReportLevelFilterable
    {
        ILayout Layout { get; set; }
        void Append(ReportLevel reportLevel, string logMessage);
    }
}
