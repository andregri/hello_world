using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms
{
    public class Monitor
    {
        public delegate double ReadSensor();
        public event ReadSensor FiveTimesPerMin;
        public event ReadSensor OncePerMin;

        public TemperatureSensor Temperature
        {
            get; set;
        }
        public PressureSensor Pressure
        {
            get; set;
        }

        private int seconds;

        private const string textformat = "Temperature: {0:F1}C\nPressure: {1:F1}";
        public string RealTimeDisplay
        {
            get
            {
                return string.Format(textformat, Temperature.Celsius, Pressure.Data);
            }
        }

        public Monitor(TemperatureSensor t, PressureSensor p)
        {
            Temperature = t;
            Pressure = p;

            OncePerMin += t.Read;
            FiveTimesPerMin += p.Read;

            seconds = 0;
        }

        public void Tick()
        {
            seconds += 1;
            if (seconds > 59)
            {
                seconds = 0;
                OncePerMin();
            }
            else if (seconds % 5 == 0)
            {
                FiveTimesPerMin();
            }
        }
    }
}
