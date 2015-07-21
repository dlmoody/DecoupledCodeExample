using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICF.Common.Logging;
using NLog;

namespace ICF.LoggingTestHarness
{
    /// <summary>
    /// An example implementation of our Common ILogger that logs using NLog. 
    /// </summary>
    public class FileLogger : ICF.Common.Logging.ILogger
    {
        private NLog.Logger logger = NLog.LogManager.GetLogger("mylog");
        public void Log(string msg)
        {
            logger.Log(LogLevel.Debug, msg);
        }
        public void LogException(string msg, Exception e)
        {
            logger.Log(LogLevel.Debug, e, msg, this);
        }
        public void Warn(string msg)
        {
            logger.Log(LogLevel.Warn, msg);
        }
        public void WarnException(string msg, Exception e)
        {
            logger.Log(LogLevel.Warn, e, msg, this);
        }

        public void Fatal(string msg)
        {
            logger.Log(LogLevel.Fatal, msg);
        }

        public void FatalException(string msg, Exception e)
        {
            logger.Log(LogLevel.Fatal, e, msg, this);
        }
    }
}
