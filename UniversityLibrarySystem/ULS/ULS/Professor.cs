using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULS
{
    public class Professor : UniversityCostumer
    {
        public Professor(string fullName, DateTime birthday, string email, string id)
            : base(fullName, birthday, email, id)
        {
            printedItemsCount = 10;
        }
    }
}
