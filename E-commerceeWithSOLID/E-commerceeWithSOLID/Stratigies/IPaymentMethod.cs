using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Strategies
{
    internal interface IPaymentMethod
    {
        void pay(decimal Amount);
    }
}
