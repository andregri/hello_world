using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULS
{
    public class Book : Item
    {
        public string Title
        {
            get; set;
        }

        public Book(string isbn, int copies, string author, string title)
            : base(isbn, copies, author)
        {
            Title = title;
        }

        public override bool IsOnline
        {
            get
            {
                return true;
            }
        }
    }
}
