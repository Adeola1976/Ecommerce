using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Task.Model
{
   public  class Supplier
    {
        public string Id { get; set; }

        public string ProductId { get; set; }
        public string SupplierName { get; set; }
        public string Phone { get; set; }

        public DateTime DateEntered { get; set; } = DateTime.Now;
        public ICollection<Product> Product { get; set; }
        public OrderDetail OrderDetail { get; set; }

    }
}
