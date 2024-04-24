using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    public enum BookingStatus {Default, Initiated, Booked, Cancelled}
    public class BookingDetails
    {
        //BookingID {Auto Increment – BID3000}, CustomerID, TotalPrice, DateOfBooking, Booking Status – Default, Initiated, Booked, 
        private static int s_bookingID = 3000;
        public string BookingID { get; }
        public string CustomerID { get; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus Status { get; set; }

        public BookingDetails(string cID, double totalPrice, DateTime dateOfBooking, BookingStatus status)
        {
            s_bookingID++;
            BookingID = "BID" + s_bookingID;
            CustomerID = cID;
            TotalPrice = totalPrice;
            Status = status;
        }
    }
}