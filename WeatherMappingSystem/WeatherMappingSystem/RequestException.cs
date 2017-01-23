using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMappingSystem
{
    public class RequestException : StationException
    {
        public override string Message
        {
            get
            {
                return string.Format("Error requesting data to station {0}.", id);
            }
        }

        public RequestException(int id) : base(id) { }
    }
}
