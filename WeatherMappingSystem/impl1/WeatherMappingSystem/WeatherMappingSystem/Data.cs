using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMappingSystem
{
    public class Data
    {
        public double Temperature
        {
            get; set;
        } 

        public double Pressure
        {
            get; set;
        }

        public double WindDirection
        {
            get; set;
        } 

        public double WindSpeed
        {
            get; set;
        }

        public Data(double t, double p, double wd, double ws)
        {
            Temperature = t;
            Pressure = p;
            WindDirection = wd;
            WindSpeed = ws;
        }
    }
}
