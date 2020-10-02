using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAndInventory
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string OrderNumber { get; set; }
        public double Discount { get; set; } = 0;
        public string OrderedDate { get; set; }
        public string ShippedDate { get; set; }
        public int status { get; set; }

    }
}
