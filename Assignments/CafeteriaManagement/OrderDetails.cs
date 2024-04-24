using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    //Enum Declaration
    /// <summary>
    /// Enum Orderstatus is the fixed values with 3 options
    /// </summary>
    public enum OrderStatus {Default, Initiated, Ordered, Cancelled}
    /// <summary>
    /// 
    /// </summary>
    public class OrderDetails
    {
        private static int s_orderID = 1000; //Read-Only field
        public string OrderID { get; }
        public string UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public OrderStatus OrderStatus { get; set; }

        //Constructor
        public OrderDetails(string userID, DateTime orderDate, double totalPrice, OrderStatus status)
        {
            s_orderID++;
            OrderID = "OID" + s_orderID;
            UserID = userID;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            OrderStatus = status;
        }

    }
}