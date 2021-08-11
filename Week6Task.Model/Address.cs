using System;
using System.Collections.Generic;
using System.Text;

namespace Week6Task.Model
{
    public class Address
    {
        public string Id { get; set; }
        public int HouseNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode{ get; set; }
        public Customer Customer { get; set; }


    }
}
