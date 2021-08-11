using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Task.Model
{
    public class OrderDetail
    {
        public string Id { get; set; }

        public string ProductId { get; set; }

        public double ProductDiscount { get; set; }
        public double ShippingDiscount { get; set; }
        public string ShippedWith { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }

        public DateTime DateEntered { get; set; } = DateTime.Now;
        public ICollection<Product> Product { get; set; }

        public ICollection<Supplier> Supplier { get; set; }

        public ICollection<Category> Category { get; set; }


        public Order Order { get; set; }
      
    }
}
