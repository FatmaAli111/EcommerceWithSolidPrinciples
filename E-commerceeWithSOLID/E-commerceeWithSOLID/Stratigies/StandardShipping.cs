using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Strategies
{
   
        public class StandardShipping : IShippingMethod
        {
            public decimal CalculateShippingCost(decimal total)
            {
                return 50; 
            }

            public int EstimatedDelieveryDays()
            {
                return 5;
            }
        }
    
}
