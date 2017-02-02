using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULS
{
    public abstract class Item
    {
        public string Isbn
        {
            get; set;
        }

        public int Copies
        {
            get; set;
        }

        public string Author
        {
            get; set;
        }

        public abstract bool IsOnline
        {
            get;
        }

        public Item(string isbn, int copies, string author)
        {
            Isbn = isbn;
            Copies = copies;
            Author = author;
        }
    }
}
