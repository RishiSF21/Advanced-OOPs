using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    public class ProductDetails
    {
        //ProductID {Auto Increment – PID2000}, ProductName, QuantityAvailable, PricePerQuantity
        private static int s_productID = 2000;
        public string ProductID { get; }
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        public double PricePerQuantity { get; set; }

        public ProductDetails(string productName, int qty, double price)
        {
            s_productID++;
            ProductID = "PID" + s_productID;
            ProductName = productName;
            QuantityAvailable = qty;
            PricePerQuantity = price;
        }
    }
}