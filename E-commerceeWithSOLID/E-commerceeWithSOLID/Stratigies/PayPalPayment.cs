using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Strategies
{
    internal class PayPalPayment : IPaymentMethod
    {
        public void pay(decimal Amount)
        {
            Console.WriteLine($"Paying {Amount} using PayPal");
        }
    }
}
