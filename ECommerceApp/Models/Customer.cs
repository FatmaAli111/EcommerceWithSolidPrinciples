using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Cart Cart { get; set; }

        public Customer(int id, string name, string email)
        {
            CustomerId = id;
            Name = name; 
            Email = email;
        }
    }
}
