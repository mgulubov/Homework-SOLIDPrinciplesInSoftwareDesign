namespace _01.ProblemLogger.Interfaces
{
    using Enums;

    public interface ILayout
    {
        string FormatLogString(ReportLevel reportLevel, string message);
    }
}
