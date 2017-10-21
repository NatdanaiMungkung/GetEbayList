using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CottoTruckTrackingSystem.Infrastructure.Concrete;

namespace CottoTruckTrackingSystemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LineAPIHelper.GetSummaryMessage();
        }
    }
}
