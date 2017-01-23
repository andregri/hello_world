using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMappingSystem
{
    public delegate Data Read();
    
    public class WMS
    {
        public Dictionary<DateTime, Data> Archive
        {
            get; set;
        }

        public WMS()
        {
            Archive = new Dictionary<DateTime, Data>();
        }

        public void Request(Station s)
        {
            DateTime time = DateTime.Today;

            Data d = s.Read();
            if (d == null)
            {
                throw new RequestException(s.id);
            }
            else if (IsValid(d))
            {
                Archive.Add(time, d);
            }
            else
            {
                throw new InvalidDataException(s.id, d);
            }
        }

        private bool IsValid(Data d)
        {
            return d.Pressure > 900 &&
                d.Temperature >= -50 && d.Temperature <= 50 &&
                d.WindDirection >= 0 && d.WindDirection < 360 &&
                d.WindSpeed > 0 && d.WindSpeed < 10;
        }
    }
}
