using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using wms;

namespace wmsTest
{
    [TestClass]
    public class UnitTest
    {
        public TemperatureSensor t;
        public PressureSensor p;

        [TestInitialize]
        public void Initialize()
        {
            t = new TemperatureSensor(1, 1);
            p = new PressureSensor(2, 5);
        }

        [TestMethod]
        public void TempUnitMeasureTest()
        {
            double celsius = t.Read();
            Assert.AreEqual(celsius + 273, t.Kelvin);
        }

        [TestMethod]
        public void PressureRisingTrendTest()
        {
            double data1 = 50, data2 = 100;
            p.Data = data1;
            p.Data = data2;
            Assert.AreEqual(PressureSensor.Trend.rising, p.PressureTrend);
        }

        [TestMethod]
        public void PressureFallingTrendTest()
        {
            double data1 = 100, data2 = 10;
            p.Data = data1;
            p.Data = data2;
            Assert.AreEqual(PressureSensor.Trend.falling, p.PressureTrend);
        }

        [TestMethod]
        public void PressureStableTrendTest()
        {
            double data1 = 20, data2 = 10;
            p.Data = data1;
            p.Data = data2;
            Assert.AreEqual(PressureSensor.Trend.stable, p.PressureTrend);
        }

        [TestMethod]
        public void MonitorTest()
        {
            Monitor m = new Monitor(t, p);
            string s = m.RealTimeDisplay;
            for (int i = 0; i <= 60; i++)
            {
                m.Tick();
                if (i == 15)
                {
                    Assert.AreEqual(string.Format("Temperature: 0,0C\nPressure: {0:F1}", p.Data), m.RealTimeDisplay);
                }
            }

            Assert.AreEqual(string.Format("Temperature: {0:F1}C\nPressure: {1:F1}", t.Celsius, p.Data), m.RealTimeDisplay);
        }
    }
}