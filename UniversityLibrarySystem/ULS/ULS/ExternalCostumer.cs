using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULS
{
    public class ExternalCostumer : Costumer
    {
        public bool HasPaidFee
        {
            get; set;
        }

        public ExternalCostumer(string fullName, DateTime birthday, string email)
            : base(fullName, birthday, email)
        {
        }

        public override void Borrow(Item item, bool onlineVersion)
        {
            base.Borrow(item, onlineVersion);

            if (!onlineVersion && item.Copies > 0)
            {
                if (HasPaidFee)
                {
                    PrintedItems.Add(item);
                    item.Copies--;
                }
                else
                {
                    throw new NotPaidFeeException(this.FullName);
                }
            }
        }
    }
}
