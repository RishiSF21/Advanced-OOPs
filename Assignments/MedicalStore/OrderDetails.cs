using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public enum OrderStatus {Default, Purchased, Cancelled}
    public class OrderDetails
    {
        private static int s_orderID = 2000;
        public string OrderID { get;  }
        public string UserID { get;  }
        public string MedicineID { get; }
        public int MedicineCount { get; set; }
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }

        //Constructor
        public OrderDetails(string uID, string mID, int medicineCount, int total, DateTime orderDate, OrderStatus status)
        {
            s_orderID++;
            OrderID = "OID" + s_orderID;
            UserID = uID;
            MedicineID = mID;
            MedicineCount = medicineCount;
            TotalPrice = total;
            OrderDate = orderDate;
            Status = status;
        }
    }
}