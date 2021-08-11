using System;
using System.Collections.Generic;
using System.Text;

namespace Week6Task.Model
{
    public class Category
    {
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Product { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
