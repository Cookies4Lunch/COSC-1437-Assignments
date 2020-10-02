using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAndInventory
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public int ProductAverageRating { get; set; }
        public int ProductSKU { get; set; }
        public string ProductManufacturer { get; set; }
        public int AvailableQuantity { get; set; }
    }
}
