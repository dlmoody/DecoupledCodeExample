using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ICF.Service;
using ICF.Common.Logging;
using NLog;
using NLog.Common;

namespace ICF.LoggingTestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var w = new Worker(new FileLogger());
            w.DoStuff();


            Console.Read();


        }
    }
}
