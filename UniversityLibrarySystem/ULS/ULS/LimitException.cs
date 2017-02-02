using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULS
{
    public class LimitException : ApplicationException
    {
        private string id;

        public override string Message
        {
            get
            {
                return string.Format("Sorry {0}, you've reached the maximum limit of borrows.", id);
            }
        }

        public LimitException(string id)
        {
            this.id = id;
        }
    }
}
