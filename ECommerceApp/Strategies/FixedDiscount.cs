using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Strategies
{
    internal class FixedDiscount : IDiscountStrategy
    {

        public double ApplyDiscount(double total, double DisountAmount)
        {
            try
            {
                if (DisountAmount < 0)
                    throw new ArgumentException("Discount amount must be greater than zero");
                if (total < DisountAmount)
                    throw new ArgumentException("Total amount must be greater than discount amount");
                return total - DisountAmount;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return total;
            }


        }
    }
}
