namespace _01.ProblemLogger.Classes.ValidatorClasses
{
    using System;
    using Enums;

    public static class DataValidator
    {
        public static void ValidateMessageString(string logMessage, string exceptionMessage)
        {
            if (string.IsNullOrEmpty(logMessage))
            {
                throw new ArgumentNullException(exceptionMessage);
            }
        }

        public static void CheckThatFilePathIsSet(string filePath, string exceptionMessage)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException(exceptionMessage);
            }
        }
    }
}
