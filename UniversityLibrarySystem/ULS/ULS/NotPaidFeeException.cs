using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULS
{
    public class NotPaidFeeException : ApplicationException
    {
        private string customerName;

        public override string Message
        {
            get
            {
                return string.Format("Sorry {0}, you can't borrow an item until you'll pay fee.", customerName);
            }
        }

        public NotPaidFeeException(string name)
        {
            this.customerName = name;
        }
    }
}
