using System;
using System.Collections.Generic;
using System.Text;

namespace Week6Task.Model
{
    public class Customer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public DateTime DateEntered { get; set; } = DateTime.Now;
        public ICollection<Address> Addresses { get; set; }
     
        public ICollection<Order>Order { get; set; }
      
    }
}
