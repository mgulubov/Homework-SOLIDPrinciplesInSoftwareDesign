namespace _01.ProblemLogger.Classes.AppenderClasses
{
    using System;
    using Interfaces;
    using Enums;

    public class ConsoleAppender : AbstractAppender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {

        }

        protected override void WriteToOutput(string logMessage)
        {
            Console.WriteLine(logMessage);
        }
    }
}
