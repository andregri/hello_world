using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMappingSystem
{
    public abstract class StationException : ApplicationException
    {
        protected readonly int id;

        public StationException(int id)
        {
            this.id = id;
        }
    }
}
