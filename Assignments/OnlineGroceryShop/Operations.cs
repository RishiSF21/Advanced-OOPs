using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    public static class Operations
    {
        //Creating list for users
        public static CustomList<CustomerDetails> customerList = new CustomList<CustomerDetails>();
        //Creating list for order details
        static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        //Creating list for cart item
        static CustomList<BookingDetails> bookingList = new CustomList<BookingDetails>();
        //Creating list for food details
        static CustomList<ProductDetails> productList = new CustomList<ProductDetails>();
        //holding current logged in user details
        static CustomerDetails currentLoggedCustomer;
        static string line = "_________________________________________________________________________________________________";
        //MainMenu
        public static void MainMenu()
        {
            int mainMenuOption;
            do{
                Console.Write("\n\t\tOnline Grocery Store\n"+line+"\n\n1. Customer Registration\n2. Login\n3. Exit\nEnter an option -> ");
                mainMenuOption = int.Parse(Console.ReadLine());
                switch(mainMenuOption)
                {
                    case 1:
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tCustomer Registration");
                        Console.WriteLine(line);
                        Register();
                        break;
                    }

                    case 2:
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tCustomer Login");
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
        
        //Register
        public static void Register()
        {
            Console.Write("\nEnter your name -> ");
            string name = Console.ReadLine();

            Console.Write("\nEnter your father name -> ");
            string father = Console.ReadLine();

            Console.Write("\nEnter your Gender [male | female] -> ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

            Console.Write("\nEnter your Mobile No -> ");
            long mobile = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter your DOB -> ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

            Console.Write("Enter your mail ID -> ");
            string mail = Console.ReadLine();

            Console.Write("Enter Wallet Amount -> ");
            double balance = Convert.ToDouble(Console.ReadLine());

            //Creating Object
            CustomerDetails customer = new CustomerDetails(name,father,gender,mobile,dob,mail,balance);
            customerList.Add(customer);

        }
        
        //Login
        public static void Login()
        {
            Console.Write("\nEnter your Customer ID -> ");
            string cID = Console.ReadLine().ToUpper();
            bool isValid = true;
            foreach (CustomerDetails customer in customerList)
            {
                if(customer.CustomerID.Equals(cID))
                {
                    currentLoggedCustomer = customer;
                    isValid = false;
                    Console.WriteLine("\n\nLogin Successfull\n");
                    SubMenu();
                    break;
                }
            }
            if(isValid)
            {
                Console.WriteLine("\nInvalid UserID");
            }
        }//Login ends
        
        //SubMenu
        public static void SubMenu()
        {
            string subOption;
            do
            {
                Console.WriteLine(line);
                Console.WriteLine("\n\t\t\tSub-Menu");
                Console.WriteLine(line+"\n");
                Console.Write("a. Show Customer Details\nb. Show Product Details\nc. Wallet Recharge\nd. Take Order\ne. Modify Order Quantity\nf. Cancel Order\ng. Show Balance\nh. Exit\n\nEnter an Option -> ");
                subOption = Console.ReadLine();
                switch(subOption)
                {
                    case "a":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tCustomer Details");
                        Console.WriteLine(line);
                        ShowCustomerDetails();
                        break;
                    }

                    case "b":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tProduct Details");
                        Console.WriteLine(line);
                        ProductDetails();
                        break;
                    }

                    case "c":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tWallet Recharge");
                        Console.WriteLine(line);
                        WalletRecharge();
                        break;
                    }

                    case "d":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tTake Order");
                        Console.WriteLine(line);
                        TakeOrder();
                        break;
                    }

                    case "e":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tModify Order Quantity");
                        Console.WriteLine(line);
                        //ModifyOrder();
                        break;
                    }

                    case "f":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tCancel Order");
                        Console.WriteLine(line);
                        //CancelOrder();
                        break;
                    }

                    case "g":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tShow Balance");
                        Console.WriteLine(line);
                        ShowBalance();
                        break;
                    }

                    case "h":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tExiting to Main-Menu");
                        Console.WriteLine(line);
                        break;
                    }

                    default:
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t\tInvalid Input");
                        Console.WriteLine(line);
                        //CustomerDetails();
                        break;
                    }
                }

            }while(subOption != "h");
        }
     
        //ShowCustomerDetails
        public static void ShowCustomerDetails()
        {
            Console.WriteLine($"\n\t\tName : {currentLoggedCustomer.CustomerID}\n\t\tFather Name : {currentLoggedCustomer.FatherName}\n\t\tGender : {currentLoggedCustomer.Gender}\n\t\tMobile : {currentLoggedCustomer.Mobile}\n\t\tDOB : {currentLoggedCustomer.DOB}\n\t\t{currentLoggedCustomer.MailID}\n\t\tWallet Balance : {currentLoggedCustomer.WalletBalance}\n");
        }//ShowCustomerDetails ends

        //ProductDetails
        public static void ProductDetails()
        {
            Console.WriteLine($"| {"ProductID",-10} | {"ProductName",-16} | {"QuantityAvailable",-18} | {"Price",-8} |");
            foreach (ProductDetails prod in productList)
            {
                Console.WriteLine($"| {prod.ProductID,-10} | {prod.ProductName,-16} | {prod.QuantityAvailable,-18} | {prod.PricePerQuantity,-8} |");               
            }
        }//ProductDetails ends
        
        //WalletRecharge
        public static void WalletRecharge()
        {
            Console.Write("\nEnter Recharge Amount -> ");
            double amount = Convert.ToDouble(Console.ReadLine());
            currentLoggedCustomer.WalletRecharge(amount);
            Console.WriteLine($"\nRecharge done successfully for Rs.{amount}");
        }//WalletRecharge Ends

        //TakeOrder
        public static void TakeOrder()
        {
            //Create booking details object
            BookingDetails booking = new BookingDetails(currentLoggedCustomer.CustomerID, 0, DateTime.Now, BookingStatus.Initiated);
            //create tempOrderList
            CustomList<OrderDetails> tempList = new CustomList<OrderDetails>();
            string purchaseAgain = "";
            double grandTotal = 0;
            do
            {
                //show product details of available stock
                Console.WriteLine($"| {"ProductID",-10} | {"ProductName",-16} | {"QuantityAvailable",-18} | {"Price",-8} |");
                foreach (ProductDetails prod in productList)
                {
                    if (prod.QuantityAvailable > 0)
                    {
                        Console.WriteLine($"| {prod.ProductID,-10} | {prod.ProductName,-16} | {prod.QuantityAvailable,-18} | {prod.PricePerQuantity,-8} |");
                    }
                }
                //ask product id
                Console.Write("\nEnter Product ID to purchase -> ");
                string userProductID = Console.ReadLine().ToUpper();
                //validate product id if valid then ask quantity
                bool isValid = true;
                foreach (ProductDetails prod in productList)
                {
                    if (prod.ProductID.Equals(userProductID))
                    {
                        isValid = false;
                        Console.WriteLine("\nEnter Quantity -> ");
                        int userQuantity = int.Parse(Console.ReadLine());
                        //check user given qty is available or not
                        if (prod.QuantityAvailable >= userQuantity)
                        {
                            //Create order object and store it in tempList
                            OrderDetails order1 = new OrderDetails(booking.BookingID,prod.ProductID,userQuantity,prod.PricePerQuantity*userQuantity);
                            orderList.Add(order1);
                            //deduct purchase count from product list
                            prod.QuantityAvailable -= userQuantity;
                            //Calculate totalPurchaseAmount
                            grandTotal += prod.PricePerQuantity*userQuantity; 
                            //display order added to the cart
                            Console.Write("\nProducts added to the cart\n\nDo you want to add another product? [yes | no] -> ");
                            //ask he wants to purchase again
                            purchaseAgain = Console.ReadLine().ToLower();
                        }
                        else
                        {
                            Console.WriteLine("\nOut of Stock");
                            break;
                        }
                    }
                }
                if(isValid)
                {
                    Console.WriteLine("Invalid Product ID");
                }
            } while (purchaseAgain == "yes");
            //Ask whether he confirm order
            Console.Write("\nDo you want to place this order -> [yes | no] : ");
            string conformOrder = Console.ReadLine().ToLower();
            if(conformOrder=="yes")
            {
                //if yes check balance
                if(currentLoggedCustomer.WalletBalance >= grandTotal)
                {
                    //if sufficient then deduct amount
                    currentLoggedCustomer.DeductAmount(grandTotal);
                    //update booking status and total price add to booking list
                    booking.TotalPrice = grandTotal;
                    booking.Status = BookingStatus.Booked;
                    //add templist to orderList and display booked successfully
                    orderList.AddRange(tempList);
                    Console.WriteLine("\nOrder Booked Successfully");
                }
                else
                {
                    Console.Write("\nNot Enough Balance\nDo you want to recharge your wallet and proceed[yes | no] -> ");
                    string rechargeOption = Console.ReadLine().ToLower();
                    if(rechargeOption=="yes")
                    {
                        Console.Write("Enter recharge amount -> ");
                        double rechargeAmt = Convert.ToInt64(Console.ReadLine());
                        currentLoggedCustomer.WalletRecharge(rechargeAmt);
                        Console.WriteLine("\nRecharge Successfull");
                    }
                    else
                    {
                        foreach (OrderDetails order in tempList)
                        {
                            foreach (ProductDetails prod in productList)
                            {
                                if (prod.ProductID.Equals(order.ProductID))
                                {
                                    prod.QuantityAvailable += order.PurchaseCount;
                                }
                            }
                        }
                        Console.WriteLine("Products removed from cart successfully");
                    }
                }
            }
            else
            {
                foreach (OrderDetails order in tempList)
                {
                    foreach (ProductDetails prod in productList)
                    {
                        if (prod.ProductID.Equals(order.ProductID))
                        {
                            prod.QuantityAvailable += order.PurchaseCount;
                        }
                    }
                }
                Console.WriteLine("Products removed from cart successfully");
            }

        }//TakeOrder ends
        
        //ModifyOrder
        public static void ModifyOrder()
        {
            Console.WriteLine($"| {"Booking ID",-12} | {"CustomerID",-12} | {"TotalPrice",-12} | {"DateOfBooking",-16} | {"BookingStatus",-16} |");
            foreach (BookingDetails booking in bookingList)
            {
                if(currentLoggedCustomer.CustomerID.Equals(booking.CustomerID) && booking.Status==BookingStatus.Booked)
                {
                    Console.WriteLine($"| {booking.BookingID,-12} | {booking.CustomerID,-12} | {booking.TotalPrice,-12} | {booking.DateOfBooking,-16} | {booking.Status,-16} |");
                }
            }
            Console.Write("\n\nEnter Booking ID to modify -> ");
            string userBookingID = Console.ReadLine();
            Console.WriteLine($"| {"OrderID",-10} | {"BookingID",-13} | {"ProductID",-12} | {"PurchaseCount",-15} | {"Price",-8} |");
            foreach (OrderDetails orders in orderList)
            {
                if (userBookingID.Equals(orders.BookingID))
                {
                    Console.WriteLine($"| {orders.OrderID,-10} | {orders.BookingID,-13} | {orders.ProductID,-12} | {orders.PurchaseCount,-15} | {orders.PriceOfOrder,-8} |");
                }

            }
            Console.Write("\nEnter Order ID to modify -> ");
            string userOrderID = Console.ReadLine();
            foreach (OrderDetails orders in orderList)
            {
                if(userOrderID.Equals(orders.OrderID))
                {
                    Console.Write("\nEnter new quantity -> ");
                    int newQty = int.Parse(Console.ReadLine());

                    foreach (ProductDetails prod in productList)
                    {
                        if(orders.ProductID.Equals(prod.ProductID))
                        {
                            orders.PurchaseCount = newQty;
                            orders.PriceOfOrder = prod.PricePerQuantity * newQty;
                            int oldQty = prod.QuantityAvailable;
                            if(newQty < oldQty)
                            {
                                prod.QuantityAvailable += oldQty - newQty;
                            }
                            else{
                                prod.QuantityAvailable -= newQty - oldQty;
                            }
                        }
                    }
                }
            }
            double grossTotal = 0;
            foreach (BookingDetails booking in bookingList)
            {
                foreach (OrderDetails order in orderList)
                {
                    if(order.BookingID.Equals(userBookingID))
                    {
                        grossTotal += order.PriceOfOrder;
                    }
                }
                booking.TotalPrice = grossTotal;
                Console.WriteLine("\nBooking Modified Successfully");
            }
        }
        //CancelOrder
        public static void CancelOrder()
        {
            Console.WriteLine("|  BookingID  |  CustomerID  |  TotalPrice  |  DateOfBooking  |  BookingStatus  |");
            foreach(BookingDetails booking in bookingList)
            {
                if(booking.CustomerID.Equals(currentLoggedCustomer.CustomerID) && booking.Status==BookingStatus.Booked)
                {
                    Console.WriteLine($"|  {booking.BookingID}  |  {booking.CustomerID}  |  {booking.TotalPrice}  |  {booking.DateOfBooking}  |  {booking.Status}  |");
                }
            }
            Console.Write("Enter Booking ID to cancel -> ");
            string cancelBookingID = Console.ReadLine().ToUpper();
            foreach(BookingDetails booking in bookingList)
            {
                if(booking.BookingID.Equals(cancelBookingID))
                {
                    booking.Status = BookingStatus.Cancelled;
                    currentLoggedCustomer.WalletRecharge(booking.TotalPrice);
                    Console.WriteLine("\nOrder Cancelled Successfully");
                }
            }
        }

        //ShowBalance
        public static void ShowBalance()
        {
            Console.WriteLine($"\n\t\tWallet Balance -> {currentLoggedCustomer.WalletBalance}\n");
        }//ShowBalance ends

        //DefaultData
        public static void DefaultData()
        {
            //Customer details reference
            CustomerDetails customer1 = new CustomerDetails("Ravi","Ettapparajan",Gender.Male,786654267,new DateTime(1999,11,11),"ravi@gmail",10000);
            CustomerDetails customer2 = new CustomerDetails("Baskaran","Sethurajan",Gender.Male,786654267,new DateTime(1999,11,11),"baskaran@gmail",15000);
            customerList.Add(customer1);
            customerList.Add(customer2);

            //ProductDetails Reference
            ProductDetails product1 = new ProductDetails("Sugar",20,40);
            ProductDetails product2 = new ProductDetails("Rice",100,50);
            ProductDetails product3 = new ProductDetails("Milk",10,40);
            ProductDetails product4 = new ProductDetails("Coffee",10,10);
            ProductDetails product5 = new ProductDetails("Tea",10,10);
            ProductDetails product6 = new ProductDetails("Masala Powder",10,20);
            ProductDetails product7 = new ProductDetails("Salt",10,10);
            ProductDetails product8 = new ProductDetails("Turmeric Powder",10,25);
            ProductDetails product9 = new ProductDetails("Chilli Powder",10,20);
            ProductDetails product10 = new ProductDetails("Groundnut Oil",10,140);

            productList.AddRange(new CustomList<ProductDetails>{product1,product2,product3,product4,product5,product6,product7,product8,product9,product10});
            
            //BookingDetails Reference
            BookingDetails booking1 = new BookingDetails(customer1.CustomerID,220,new DateTime(2022,07,26),BookingStatus.Booked);
            BookingDetails booking2 = new BookingDetails(customer2.CustomerID,400,new DateTime(2022,07,26),BookingStatus.Booked);
            BookingDetails booking3 = new BookingDetails(customer1.CustomerID,280,new DateTime(2022,07,26),BookingStatus.Cancelled);
            BookingDetails booking4 = new BookingDetails(customer2.CustomerID,0,new DateTime(2022,07,26),BookingStatus.Initiated);

            bookingList.AddRange(new CustomList<BookingDetails>{booking1,booking2,booking3,booking4});

            //Orderdetails Reference
            OrderDetails order1 = new OrderDetails(booking1.BookingID,product1.ProductID,2,80);
            OrderDetails order2 = new OrderDetails(booking1.BookingID,product2.ProductID,2,100);
            OrderDetails order3 = new OrderDetails(booking1.BookingID,product3.ProductID,1,40);
            OrderDetails order4 = new OrderDetails(booking2.BookingID,product1.ProductID,1,40);
            OrderDetails order5 = new OrderDetails(booking2.BookingID,product2.ProductID,4,200);
            OrderDetails order6 = new OrderDetails(booking2.BookingID,product10.ProductID,1,140);
            OrderDetails order7 = new OrderDetails(booking2.BookingID,product9.ProductID,1,20);
            OrderDetails order8 = new OrderDetails(booking3.BookingID,product2.ProductID,2,100);
            OrderDetails order9 = new OrderDetails(booking3.BookingID,product8.ProductID,4,100);
            OrderDetails order10 = new OrderDetails(booking3.BookingID,product1.ProductID,2,80);

            orderList.AddRange(new CustomList<OrderDetails>{order1,order2,order3,order4,order5,order6,order7,order8,order9,order10});

        }
    }
}