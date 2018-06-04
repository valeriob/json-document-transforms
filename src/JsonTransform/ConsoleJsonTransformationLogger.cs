namespace JsonTransform
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.Jdt;

    public class ConsoleJsonTransformationLogger : IJsonTransformationLogger
    {
        public void LogError(string message)
        {
            throw new NotImplementedException();
        }

        public void LogError(string message, string fileName, int lineNumber, int linePosition)
        {
            throw new NotImplementedException();
        }

        public void LogErrorFromException(Exception ex)
        {
            throw new NotImplementedException();
        }

        public void LogErrorFromException(Exception ex, string fileName, int lineNumber, int linePosition)
        {
            throw new NotImplementedException();
        }

        public void LogMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void LogMessage(string message, string fileName, int lineNumber, int linePosition)
        {
            throw new NotImplementedException();
        }

        public void LogWarning(string message)
        {
            throw new NotImplementedException();
        }

        public void LogWarning(string message, string fileName)
        {
            throw new NotImplementedException();
        }

        public void LogWarning(string message, string fileName, int lineNumber, int linePosition)
        {
            throw new NotImplementedException();
        }
    }
}
