using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULS
{
    public abstract class Costumer
    {
        public string FullName
        {
            get; private set;
        }

        public DateTime Birthday
        {
            get; private set;
        }

        public string Email
        {
            get; set;
        }

        public List<Item> PrintedItems
        {
            get; set;
        }

        public List<Item> OnlineItems
        {
            get; set;
        }

        public Costumer(string fullName, DateTime birthday, string email)
        {
            FullName = fullName;
            Birthday = birthday;
            Email = email;
            PrintedItems = new List<Item>();
            OnlineItems = new List<Item>();
        }

        public virtual void Borrow(Item item, bool onlineVersion)
        {
            if (onlineVersion && item.IsOnline)
            {
                OnlineItems.Add(item);
            }
            else if (!onlineVersion) //printed version
            {
                if (item.Copies == 0)
                {
                    throw new SoldOutException(item.Isbn);
                }
            }
            else
            {
                // to implement
            }
        }
    }
}
