using System;

namespace ClassLibraryNetCore.OneToMany
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
