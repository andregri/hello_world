using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULS
{
    public class SoldOutException : ApplicationException
    {
        private string isbn;

        public override string Message
        {
            get
            {
                return string.Format("Sorry, {0} is sold out. We'll alert you when it'll be available again.", isbn);
            }
        }

        public SoldOutException(string isbn)
        {
            this.isbn = isbn;
        }
    }
}
