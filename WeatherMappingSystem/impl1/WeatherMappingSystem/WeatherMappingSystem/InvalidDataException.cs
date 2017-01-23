using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMappingSystem
{
    public class InvalidDataException : StationException
    {
        public Data InvalidData
        {
            get;
            private set;
        }

        public override string Message
        {
            get
            {
                return string.Format("Invalid data receveid from station {0}.", id);
            }
        }

        public InvalidDataException(int id, Data d) : base(id)
        {
            InvalidData = d;
        }
    }
}
