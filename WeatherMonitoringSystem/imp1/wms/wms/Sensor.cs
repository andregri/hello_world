using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms
{
    public abstract class Sensor
    {
        static protected Random rm = new Random();

        public virtual int UpdatingRate //times per minute
        {
            get; set;
        }

        public long Id
        {
            get;
        }

        public Sensor(long id, int updatingRate)
        {
            Id = id;
            UpdatingRate = updatingRate;
        }

        public abstract double Read();
    }
}
