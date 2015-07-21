using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ICF.Common.Logging;
using ICF.Service;
using ICF.LoggingTestHarness;

namespace ICF.Service.Test
{
    [TestClass]
    public class WorkerTest
    {
        [TestMethod]
        public void WorkerServiceDoesWork()
        {
            var worker = new Worker(new FileLogger());
            var expected = true;

            var actual = worker.DoStuff();

            Assert.AreEqual(expected, actual, "something went wrong");
        }
    }
}
