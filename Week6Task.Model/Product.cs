using System;
using System.Collections.Generic;
using System.Text;

namespace Week6Task.Model
{
    public class Product
    {
        public string Id { get; set; }

        public string ProductName { get; set; }

        public string Categoryid { get; set; }
        public string Supplierid { get; set; }
        public double UnitPrice { get; set; }
        public double QuatityPerUnit { get; set; }
        public string Description { get; set; }

        public DateTime DateEntered { get; set; } = DateTime.Now;
        public Category Category { get; set; }
        public ICollection<Supplier> Supplier { get; set; }
        public OrderDetail OrderDetails { get; set; }
        public ICollection<Order> OrderDetail { get; set; }





    }
}
