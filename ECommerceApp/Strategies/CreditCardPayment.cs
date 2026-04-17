using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Strategies
{
       public class CreditCardPayment : IPaymentMethod
       {
            public void pay(decimal amount)
            {
                Console.WriteLine($"Paying {amount} using Credit Card");
            }
       }
    
}
