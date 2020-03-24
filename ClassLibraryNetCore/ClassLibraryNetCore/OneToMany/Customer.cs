using System.Collections.Generic;

namespace ClassLibraryNetCore.OneToMany
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public IList<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new List<Order>();
        }
        public override string ToString()
        {
            return $"ID: {CustomerId} Name: {Name} City: {City}";
        }
    }
}
