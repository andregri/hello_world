using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULS
{
    public class UniversityCostumer : Costumer
    {
        public readonly string id;
        protected int printedItemsCount;

        public UniversityCostumer(string fullName, DateTime birthday, string email, string id)
            : base(fullName, birthday, email)
        {
            this.id = id;
        }

        public override void Borrow(Item item, bool onlineVersion)
        {
            base.Borrow(item, onlineVersion);

            if (!onlineVersion && item.Copies > 0)
            {
                if (PrintedItems.Count < printedItemsCount)
                {
                    PrintedItems.Add(item);
                    item.Copies--;
                }
                else
                {
                    throw new LimitException(this.id);
                }
            }
        }
    }
}
