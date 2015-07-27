namespace _01.ProblemLogger.Interfaces
{
    public interface IFileAppender : IAppender
    {
        string File { get; set; }
    }
}
