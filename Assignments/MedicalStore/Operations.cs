using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public static class Operations
    {
        static List<UserDetails> userList = new List<UserDetails>();
        static List<MedicineDetails> medicineList = new List<MedicineDetails>();
        static List<OrderDetails> orderList = new List<OrderDetails>();
        static UserDetails currentLoggedUser;
        static string line = "__________________________________________________________________";

        //MainMenu
        public static void MainMenu()
        {
            int mainMenuOption;
            do
            {
                Console.WriteLine(line);
                Console.WriteLine("\n\t\t\tApollo Medical Store");
                Console.WriteLine(line);
                Console.Write("\n1. User Registration\n2. User Login\n3. Exit\n\nEnter an option -> ");
                mainMenuOption = int.Parse(Console.ReadLine());
                switch(mainMenuOption)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine(line);
                            Console.WriteLine("\n\t\t\tUser Registration");
                            Console.WriteLine(line);
                            Register();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine(line);
                            Console.WriteLine("\n\t\t\tUser Login");
                            Console.WriteLine(line);
                            Login();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine(line);
                            Console.WriteLine("\n\t\t\tApplication Exited Successfully");
                            Console.WriteLine(line);
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine(line);
                            Console.WriteLine("\n\t\t\tInvalid Option");
                            Console.WriteLine(line);
                            break;
                        }
                }
            }while(mainMenuOption != 3);
        }
        
        //Register()
        public static void Register()
        {
            Console.Write("\nEnter your name -> ");
            string name = Console.ReadLine();

            Console.Write("\nEnter your Age -> ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("\nEnter your City -> ");
            string city = Console.ReadLine();

            Console.Write("\nEnter Mobile Number -> ");
            string mobile = Console.ReadLine();

            Console.Write("\nEnter Wallet Balance -> ");
            int balance = int.Parse(Console.ReadLine());

            UserDetails users = new UserDetails(name, age, city, mobile, balance);
            userList.Add(users);

            Console.WriteLine($"\nUser Registration Successfull..Your UserID -> {users.UserID}");
        }
        
        //Login()
        public static void Login()
        {
            Console.Write("\nEnter UserID -> ");
            string loginID = Console.ReadLine().ToUpper();
            foreach(UserDetails user in userList)
            {
                if(user.UserID.Equals(loginID))
                {
                    currentLoggedUser = user;
                    Console.WriteLine("\nLogin Successfull");
                    SubMenu();
                    break;
                }
            }
        }
        
        //Submenu
        public static void SubMenu()
        {
            string subOption;
            do
            {
                Console.WriteLine(line);
                Console.WriteLine("\n\t\t\tSub-Menu");
                Console.WriteLine(line);
                Console.Write("\na. Show Medicine List\nb. Purchase Medicine\nc. Modify Purchase\nd. Cancel Purchase\ne. Show Purchase History\nf. Recharge Wallet\ng. Show Wallet Balance\nh. Back to Main-Menu\nEnter an option -> ");
                subOption = Console.ReadLine();
                switch(subOption)
                {
                    case "a":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tMedicine List");
                        Console.WriteLine(line);
                        MedicineList();
                        break;
                    }
                    case "b":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tPurchase Medicine");
                        Console.WriteLine(line);
                        PurchaseMedicine();
                        break;
                    }
                    case "c":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tModify Purchase");
                        Console.WriteLine(line);
                        ModifyPurchase();
                        break;
                    }
                    case "d":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tCancelPurchase");
                        Console.WriteLine(line);
                        CancelPurchase();
                        break;
                    }
                    case "e":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tPurchase History");
                        Console.WriteLine(line);
                        PurchaseHistory();
                        break;
                    }
                    case "f":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tWallet Recharge");
                        Console.WriteLine(line);
                        RechargeWallet();
                        break;
                    }
                    case "g":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine($"\n\t\t\t{currentLoggedUser.Name}'s Wallet");
                        Console.WriteLine(line);
                        ShowWallet();
                        break;
                    }
                    case "h":
                    {
                        break;
                    }
                    default:
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tInvalid Option");
                        Console.WriteLine(line);
                        break;
                    }
                }
            }while(subOption != "h");
        }
        
        // MedicineList
        public static void MedicineList()
        {
            Console.WriteLine();
            Console.WriteLine($"| {"MedicineID",-12} | {"MedicineName",-18} | {"AvailableCount",-16} | {"Price",-6} | {"ExpiryDate",-12} |");
            foreach(MedicineDetails medicines in medicineList)
            {
                Console.WriteLine($"\n| {medicines.MedicineID,-12} | {medicines.MedicineName,-18} | {medicines.AvailableCount,-16} | {medicines.Price,-6} | {medicines.DateOfExpiry.ToString("dd/MM/yyyy"),-12} |");
            }
        }
        //PurchaseMedicine
        public static void PurchaseMedicine()
        {
            Console.WriteLine();
            Console.WriteLine($"| {"MedicineID",-12} | {"MedicineName",-18} | {"AvailableCount",-16} | {"Price",-6} | {"ExpiryDate",-12} |");
            foreach(MedicineDetails medicines in medicineList)
            {
                Console.WriteLine($"\n| {medicines.MedicineID,-12} | {medicines.MedicineName,-18} | {medicines.AvailableCount,-16} | {medicines.Price,-6} | {medicines.DateOfExpiry.ToString("dd/MM/yyyy"),-12} |");
            }
            Console.Write("\nEnter Medicine ID for purchase -> ");
            string buyMedicineID = Console.ReadLine().ToUpper();
            bool isValidID = true;
            foreach (MedicineDetails medicines in medicineList)
            {
                if(buyMedicineID.Equals(medicines.MedicineID))
                {
                    isValidID = false;
                    Console.Write("\nEnter medicine count -> ");
                    int buyCount = int.Parse(Console.ReadLine());
                    if(medicines.AvailableCount >= buyCount)
                    {
                        int checkExpiry = DateTime.Compare(DateTime.Now,medicines.DateOfExpiry);
                        if(checkExpiry < 0)
                        {
                            if(currentLoggedUser.WalletBalance >= medicines.Price*buyCount)
                            {
                                medicines.AvailableCount -= buyCount;
                                currentLoggedUser.DeductBalance(medicines.Price*buyCount);
                                OrderDetails order1 = new OrderDetails(currentLoggedUser.UserID,medicines.MedicineID,buyCount,medicines.Price*buyCount,DateTime.Now,OrderStatus.Purchased);
                                orderList.Add(order1);
                                Console.WriteLine("\nMedicine Purchased Successfully");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nYou don't have enough balance to purchase this medicine.\nPlease recharge your wallet and try again.");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"\nMedicine ID {medicines.MedicineID} was expired");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\nMedicine is not available for the given quantity");
                        break;
                    }
                }
            }
            if(isValidID)
            {
                Console.WriteLine("Invalid MedicineID");
            }
        }
        //ModifyPurchase
        public static void ModifyPurchase()
        {
            Console.WriteLine($"| {"OrderID",-8} | {"UserID",-8} | {"MedicineID",-11} | {"MedicineCount",-14} | {"TotalPrice",-10} | {"OrderDate",-11} | {"Order Status",-14} |");
            foreach(OrderDetails orders in orderList)
            {
                if(orders.UserID.Equals(currentLoggedUser.UserID) && orders.Status == OrderStatus.Purchased)
                {
                    Console.WriteLine();
                    Console.WriteLine($"| {orders.OrderID,-8} | {orders.UserID,-8} | {orders.MedicineID,-11} | {orders.MedicineCount,-14} | {orders.TotalPrice,-10} | {orders.OrderDate.ToString("dd/MM/yyyy"),-11} | {orders.Status,-14} |");
                }
            }
            Console.Write("\nEnter order ID to modify -> ");
            string modifyOrder = Console.ReadLine().ToUpper();
            bool isOrderID = true;
            foreach(OrderDetails orders in orderList)
            {
                if(orders.OrderID.Equals(modifyOrder))
                {
                    isOrderID = false;
                    Console.Write("Enter new quantity -> ");
                    int newQty = int.Parse(Console.ReadLine());
                    foreach(MedicineDetails medicines in medicineList)
                    {
                        if(orders.MedicineID.Equals(medicines.MedicineID))
                        {
                            medicines.AvailableCount -= newQty;
                            orders.TotalPrice += medicines.Price * newQty;
                            orders.MedicineCount += newQty;
                            currentLoggedUser.DeductBalance(medicines.Price * newQty);
                            Console.WriteLine($"\nOrder ID {orders.OrderID} was modified successfully");
                            break;
                        }
                    }
                }
            }
            if(isOrderID)
            {
                Console.WriteLine("\nInvalid OrderID");
            }
        }
        //CancelPurchase
        public static void CancelPurchase()
        {
            Console.WriteLine($"| {"OrderID",-8} | {"UserID",-8} | {"MedicineID",-11} | {"MedicineCount",-14} | {"TotalPrice",-10} | {"OrderDate",-11} | {"Order Status",-14} |");
            foreach(OrderDetails orders in orderList)
            {
                if(orders.UserID.Equals(currentLoggedUser.UserID) && orders.Status == OrderStatus.Purchased)
                {
                    Console.WriteLine();
                    Console.WriteLine($"| {orders.OrderID,-8} | {orders.UserID,-8} | {orders.MedicineID,-11} | {orders.MedicineCount,-14} | {orders.TotalPrice,-10} | {orders.OrderDate.ToString("dd/MM/yyyy"),-11} | {orders.Status,-14} |");
                }
            }
            Console.Write("\nEnter order ID to cancel order -> ");
            string cancelOrder = Console.ReadLine().ToUpper();
            bool isOrderID = true;
            foreach(OrderDetails orders in orderList)
            {
                if(orders.UserID.Equals(currentLoggedUser.UserID) && orders.Status == OrderStatus.Purchased)
                {
                    isOrderID = false;
                    foreach(MedicineDetails medicines in medicineList)
                    {
                        if(orders.MedicineID.Equals(medicines.MedicineID))
                        {
                            medicines.AvailableCount += orders.MedicineCount;
                            orders.Status = OrderStatus.Cancelled;
                            currentLoggedUser.WalletRecharge(orders.TotalPrice);
                            Console.WriteLine($"\nOrder ID {cancelOrder} has been cancelled successfully");
                            break;
                        }
                    }
                    break;
                }
            }
            if(isOrderID)
            {
                Console.WriteLine("Invalid Order ID");
            }
        }
        //PurchaseHistory
        public static void PurchaseHistory()
        {
            bool isFound = true;
            foreach(OrderDetails orders in orderList)
            {
                if(orders.UserID.Equals(currentLoggedUser.UserID))
                {
                    isFound = false;
                    Console.WriteLine($"| {"Order ID",-10} | {"User ID",-9} | {"Medicine ID",-12} | {"Medicine Count",-15} | {"Total Price",-12} | {"Order Date",-12} | {"Order Status",-14} |");
                    break;
                }
            }
            if(isFound)
            {
                Console.WriteLine("\nYou don't have any orders to show");
            }

            foreach(OrderDetails orders in orderList)
            {
                if(orders.UserID.Equals(currentLoggedUser.UserID))
                {
                    Console.WriteLine();
                    Console.WriteLine($"| {orders.OrderID,-10} | {orders.UserID,-9} | {orders.MedicineID,-12} | {orders.MedicineCount,-15} | {orders.TotalPrice,-12} | {orders.OrderDate.ToString("dd/MM/yyyy"),-12} | {orders.Status,-14}");
                }
            }
        }

        //RechargeWallet
        public static void RechargeWallet()
        {
            Console.Write("\nEnter Recharge Amount -> ");
            int amount = int.Parse(Console.ReadLine());
            currentLoggedUser.WalletRecharge(amount);
            Console.WriteLine($"\nWallet recharge done successfully for Rs.{amount}");
        }
        
        //ShowWallet
        public static void ShowWallet()
        {
            Console.WriteLine($"\nWallet Balance --> {currentLoggedUser.WalletBalance}");
        }
        //DefaultData
        public static void DefaultData()
        {
            //UserDetails Class
            UserDetails user1 = new UserDetails("Ravi",33,"Theni","9877774404",400);
            UserDetails user2 = new UserDetails("Baskaran",33,"Chennai","8890774404",500);
            userList.Add(user1);
            userList.Add(user2);

            //MedicineDetails
            MedicineDetails medicine1 = new MedicineDetails("Paracitamol",40,5,new DateTime(2024,06,30));
            MedicineDetails medicine2 = new MedicineDetails("Calpol",10,5,new DateTime(2024,05,30));
            MedicineDetails medicine3 = new MedicineDetails("Gelucil",3,40,new DateTime(2023,04,30));
            MedicineDetails medicine4 = new MedicineDetails("Metrogel",5,50,new DateTime(2024,12,30));
            MedicineDetails medicine5 = new MedicineDetails("Povidin Iodin",10,50,new DateTime(2024,10,30));
            medicineList.AddRange(new List<MedicineDetails>{medicine1,medicine2,medicine3,medicine4,medicine5});

            //OrderDetails
            OrderDetails order1 = new OrderDetails(user1.UserID,medicine1.MedicineID,3,15,new DateTime(2022,11,13),OrderStatus.Purchased);
            OrderDetails order2 = new OrderDetails(user1.UserID,medicine2.MedicineID,2,10,new DateTime(2022,11,13),OrderStatus.Cancelled);
            OrderDetails order3 = new OrderDetails(user1.UserID,medicine4.MedicineID,2,100,new DateTime(2022,11,13),OrderStatus.Purchased);
            OrderDetails order4 = new OrderDetails(user2.UserID,medicine3.MedicineID,3,120,new DateTime(2022,11,15),OrderStatus.Cancelled);
            OrderDetails order5 = new OrderDetails(user2.UserID,medicine5.MedicineID,5,250,new DateTime(2022,11,15),OrderStatus.Purchased);
            OrderDetails order6 = new OrderDetails(user2.UserID,medicine2.MedicineID,3,15,new DateTime(2022,11,15),OrderStatus.Purchased);
            orderList.AddRange(new List<OrderDetails>{order1,order2,order3,order4,order5,order6});
        }
    }
}