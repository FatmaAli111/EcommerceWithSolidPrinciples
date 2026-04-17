using ECommerceApp.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceeWithSOLID
{
    class Order
    {
        public IShippingMethod ShippingMethod { get; set; }
        public IPaymentMethod PaymentMethod { get; set; }
        public INotificationSender NotificationSender { get; set; }
        public IDiscountStrategy DiscountStrategy { get; set; }
        public decimal DiscountAmount { get; }
        public decimal Total { get; }

        public Order(IShippingMethod ShippingMethod, IPaymentMethod PaymentMethod, INotificationSender NotificationSender, 
            IDiscountStrategy DiscountStrategy,decimal DiscountAmount=0, decimal total = 0)
        {
            this.ShippingMethod = ShippingMethod;
            this.PaymentMethod = PaymentMethod;
            this.NotificationSender = NotificationSender;
            this.DiscountStrategy = DiscountStrategy;
            this.DiscountAmount = DiscountAmount;
            Total = total;
        }

        
        public void Checkout()
        {
            var discountedTotal = DiscountStrategy.ApplyDiscount((double)Total,(double)DiscountAmount);

            var shippingCost = ShippingMethod.CalculateShippingCost((decimal)discountedTotal);

            var finalAmount = (decimal)discountedTotal + shippingCost;

            PaymentMethod.pay(finalAmount);

            NotificationSender.send($"Order completed. Total: {finalAmount}");
        }
    }
}
