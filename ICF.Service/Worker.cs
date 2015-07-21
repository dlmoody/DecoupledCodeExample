using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICF.Common;

namespace ICF.Service
{
    public class Worker
    {
        private readonly Common.Logging.ILogger _logger;

        public Worker(Common.Logging.ILogger logger)
        {
            _logger = logger;
        }
        public bool DoStuff()
        {
            Console.WriteLine("Doing lots of work...");
            _logger.Log("doing things");
            return true;
        }
    }
}
