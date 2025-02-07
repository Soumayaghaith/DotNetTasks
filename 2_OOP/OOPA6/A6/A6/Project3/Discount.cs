using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6.Project3
{
    internal abstract class Discount
    {
        public string Name { get; set; }
        public abstract decimal CalculateDiscount(decimal price, int quantity);


    }

    class PercentageDiscount : Discount
    {
        public decimal Percentage { get; set; }
        public PercentageDiscount(int percentage)
        {
             Percentage = percentage;
             Name = "PercentageDiscount";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (Percentage / 100);

        }
        
    }
    class FlatDiscount : Discount
    {
        public decimal FixedDeduction { get; set; }
        public FlatDiscount(decimal fixedDeduction)
        {
            FixedDeduction = fixedDeduction;
            Name = "FlatDiscount";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return FixedDeduction * Math.Min(quantity, 1);
        }
    }

    class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "BuyOneGetOneDiscount";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity > 1)
            {
                return (price / 2) * (quantity / 2);
            }
            else
                return 0;

        }
    }
    class NoDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return 0;
        }
    }

}
