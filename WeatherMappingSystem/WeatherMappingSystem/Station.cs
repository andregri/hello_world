using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMappingSystem
{
    public abstract class Station
    {
        Data CurrentData
        {
            get; set;
        }

        public readonly int id;

        public Station(int id)
        {
            this.id = id;
        }

        public abstract Data Read();
    }
}
