using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Strategies
{
    internal class SMSSender : INotificationSender
    {
        public void send(string Message)
        {
            Console.WriteLine($"sending {Message} using SMS ");
        }
    }
}
