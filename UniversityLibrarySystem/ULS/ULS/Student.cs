using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULS
{
    public class Student : UniversityCostumer
    {
        public Student(string fullName, DateTime birthday, string email, string id)
            : base(fullName, birthday, email, id)
        {
            printedItemsCount = 3;
        }
    }
}
