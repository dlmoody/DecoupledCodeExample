using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICF.Common.Logging
{
    public interface ILogger
    {
        void Log(string msg);
        void LogException(string msg, Exception e);
        void Warn(string msg);
        void WarnException(string msg, Exception e);
        void Fatal(string msg);
        void FatalException(string msg, Exception e);
    }
}
