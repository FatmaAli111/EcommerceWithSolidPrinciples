using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public List<CartItem> Items { get; private set; } = new List<CartItem>();
        public Customer Customer { get; set; }

        public Cart(int cartId, Customer customer)
        {
            CartId = cartId;
            Customer = customer;
        }

        public void AddItem(Product product, int quantity)
        {
            var existing = Items.FirstOrDefault(i => i.Product.Id == product.Id);
            if (existing != null)
                existing.Quantity += quantity;
            else
                Items.Add(new CartItem(product, quantity));
        }

        public void RemoveItem(int productId)
        {
            Items.RemoveAll(i => i.Product.Id == productId);
        }

        public decimal GetTotal()
        {
            return Items.Sum(i => i.Subtotal);
        }
    }
}
