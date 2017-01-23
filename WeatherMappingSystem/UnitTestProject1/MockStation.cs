using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMappingSystem;

namespace UnitTestProject1
{
    internal class MockStation : Station
    {
        public Data TestData
        {
            get; set;
        }

        public MockStation(int id)
            : base(id)
        {
        }

        public override Data Read()
        {
            return TestData;
        }
    }
}
