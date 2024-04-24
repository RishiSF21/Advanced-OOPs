using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class FoodDetails
    {
        private static int s_foodID = 100;
        public string FoodID { get; }
        public string FoodName { get; set; }
        public double FoodPrice { get; set; }
        public int AvailableQuantity { get; set; }

        //Constructor
        public FoodDetails(string foodName, double price, int quantity)
        {
            s_foodID++;
            FoodID = "FID" + s_foodID;
            FoodName = foodName;
            FoodPrice = price;
            AvailableQuantity = quantity;
        }
    }
}