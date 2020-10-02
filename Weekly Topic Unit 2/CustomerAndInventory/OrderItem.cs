using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAndInventory
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }


    }
}
