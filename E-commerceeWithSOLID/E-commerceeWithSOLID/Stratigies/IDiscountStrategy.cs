using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Strategies
{
    internal interface IDiscountStrategy
    {

        double ApplyDiscount(double total, double Discount);
    }
}
