using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Strategies
{
    internal class ExpressShipping : IShippingMethod
    {
        public decimal CalculateShippingCost(decimal total)
        {
            return total * 0.1m;
        }

        public int EstimatedDelieveryDays()
        {
            return 2;
        }
    }
}
