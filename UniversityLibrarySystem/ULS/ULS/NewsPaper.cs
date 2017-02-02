using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULS
{
    public class NewsPaper : Item
    {
        public DateTime ReleaseDate
        {
            get; set;
        }

        public NewsPaper(string isbn, int copies, string author, DateTime date)
            : base(isbn, copies, author)
        {
            ReleaseDate = date;
        }

        public override bool IsOnline
        {
            get
            {
                return false;
            }
        }
    }
}
