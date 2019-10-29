using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Customer
    {
        public List<Order> Orders { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public int Id1 { get; set; }
        public int Id2 { get; set; }
        public int Id3 { get; set; }
    }




}
