using Microsoft.Extensions.Logging;
using Service;

namespace Logger
{
    public class LoggerService(ILogger<LoggerService> logger) : ILoggerService
    {
        public void Debug(string message)
        {
            logger.LogDebug(message);
        }

        public void Error(string message)
        {
            logger.LogError(message);
        }

        public void Info(string message)
        {
            logger.LogInformation(message);
        }
    }
}
