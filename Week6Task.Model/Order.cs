using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Task.Model
{
    public class Order
    {
        public string Id { get; set; }

     
        public string Status { get; set; }
        public DateTime DateEntered { get; set; } = DateTime.Now;

        public Customer Customers { get; set; }

        public ICollection<Shipper> Shippers { get; set; }
        public ICollection<Product> Product { get; set; }   
        public ICollection <OrderDetail> OrderDetail { get; set; }
    }
}
