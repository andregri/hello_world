using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherMappingSystem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        WMS wms;
        MockStation s;
        Data testData;
        Data invalidData;

        [TestInitialize]
        public void Initialize()
        {
            testData = new Data(1, 1000, 300, 3);
            invalidData = new Data(1, 1, -3, 4);

            wms = new WMS();
            s = new MockStation(1);
        }
                
        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void TestInvalidData()
        {
            s.TestData = invalidData;
            wms.Request(s);
        }

        [TestMethod]
        [ExpectedException(typeof(RequestException))]
        public void TestRequestError()
        {
            s.TestData = null;
            wms.Request(s);
        }

        [TestMethod]
        public void TestValidData()
        {
            s.TestData = testData;
            wms.Request(s);
            Assert.AreEqual(1, wms.Archive.Keys.Count);
            Assert.AreSame(testData, wms.Archive[DateTime.Today]);
        }
    }
}
