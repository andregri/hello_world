using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms
{
    public class PressureSensor : Sensor
    {
        public enum Trend { rising, falling, stable };

        private double[] data;

        public double Data
        {
            get
            {
                return data[1];
            }
            set
            {
                data[0] = data[1];
                data[1] = value;
            }
        }

        public Trend PressureTrend
        {
            get
            {
                double diff = data[1] - data[0];
                if (diff > 20)
                {
                    return Trend.rising;
                }
                else if (diff < -20)
                {
                    return Trend.falling;
                }
                else
                {
                    return Trend.stable;
                }
            }
        }

        public PressureSensor(long id, int updatingRate)
            : base(id, updatingRate)
        {
            data = new double[2];
        }

        public override double Read()
        {
            Data = rm.Next(0, 200);
            return Data;
        }
    }
}
