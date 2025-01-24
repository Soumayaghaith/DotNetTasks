using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6.Project3
{
    abstract internal class User
    {
        public string Name { get; set; }

        public abstract Discount GetDiscount();
            
    }

    class RegularUser : User
    {
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }

    class PremiumUser : User
    {
        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }

    class GuestUser : User
    {
        public override Discount GetDiscount()
        {
            return new NoDiscount();
        }
    }

}
