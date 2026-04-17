using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Strategies
{
    internal class PercentageDiscount : IDiscountStrategy

    {
        public double ApplyDiscount(double total, double Percentage)
        {
            try
            {
                if (Percentage < 0)
                    throw new ArgumentException("Discount Percentage must be greater than zero");
                if (total < total*Percentage)
                    throw new ArgumentException("Total amount must be greater than discount Percentage times Total");
                return total - total*Percentage;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return total;
            }


        }
    }
}
