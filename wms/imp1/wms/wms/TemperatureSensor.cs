using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms
{
    public class TemperatureSensor : Sensor
    {
        private double celsiusData;

        public double Celsius
        {
            get
            {
                return celsiusData;
            }
        }

        public double Kelvin
        {
            get
            {
                return Celsius + 273;
            }
        }

        public TemperatureSensor(long id, int updatingRate)
            : base(id, updatingRate)
        {

        }

        public override double Read()
        {
            //read a celsius value
            celsiusData = rm.Next(-20, 40);
            return celsiusData;
        }
    }
}