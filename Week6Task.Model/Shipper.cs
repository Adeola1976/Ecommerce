using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Task.Model
{
  public   class Shipper
    {
        public string Id { get; set; }

        public string CompanyName { get; set; }
        public string FeedBack { get; set; }
        public DateTime DateEntered { get; set; } = DateTime.Now;
        public Order Order { get; set; }

    }
}
