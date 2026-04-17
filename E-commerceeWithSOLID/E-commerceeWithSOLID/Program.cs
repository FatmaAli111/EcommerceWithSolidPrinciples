using ECommerceApp.Models;
using ECommerceApp.Strategies;

namespace E_commerceeWithSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product(1, "Laptop", 10000);
            var product2 = new Product(2, "Mouse", 200);

            var customer = new Customer(1, "Fatma", "fatma@gmail.com");

            var cart = new Cart(1, customer);
            customer.Cart = cart;

            cart.AddItem(product1, 1);   
            cart.AddItem(product2, 2);   

            Console.WriteLine("Cart Total: " + cart.GetTotal());

            IDiscountStrategy discount = new FixedDiscount();
            IShippingMethod shipping = new StandardShipping();
            IPaymentMethod payment = new CreditCardPayment();
            INotificationSender notification = new EmailSender();

            var order = new Order(
                shipping,
                payment,
                notification,
                discount,
                total: cart.GetTotal()
            );

            order.Checkout();

        }
    }
}
