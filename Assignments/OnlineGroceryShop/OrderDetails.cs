using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    public class OrderDetails
    {
        //OrderID {Auto Increment – OID4000}, BookingID, ProductID, PurchaseCount, PriceOfOrder
        private static int s_orderID = 4000;
        public string OrderID { get; }
        public string BookingID { get; }
        public string ProductID { get;  }
        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }

        public OrderDetails(string bID, string pID, int count, double priceOfOrder)
        {
            s_orderID++;
            OrderID = "OID" + s_orderID;
            BookingID = bID;
            ProductID = pID;
            PurchaseCount = count;
            PriceOfOrder = priceOfOrder;
        }
    }
}