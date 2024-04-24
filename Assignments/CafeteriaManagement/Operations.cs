using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public static class Operations
    {
        //Creating list for users
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        //Creating list for order details
        static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        //Creating list for cart item
        static CustomList<CartItem> cartList = new CustomList<CartItem>();
        //Creating list for food details
        static CustomList<FoodDetails> foodList = new CustomList<FoodDetails>();
        //holding current logged in user details
        static UserDetails currentLoggedUser;

        //Main menu
        static string line = "_______________________________________________________________";
        public static void MainMenu()
        {
            //Need to display main menu options
            int mainMenuOption;
            do{
                Console.WriteLine(line);
                Console.Write("\n\t\tWelcome to Road House Cafeteria !!\n"+line+"\n\n1. User Registration\n2. User Login\n3. Exit\nSelect any option to proceed -> ");
                //Need to get the option from the user
                mainMenuOption = int.Parse(Console.ReadLine());
                switch(mainMenuOption)
                {
                    case 1:
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\t\t User Registration");
                        Console.WriteLine(line);
                        Register();
                        break;
                    }
                    case 2:
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\t\t User Login");
                        Console.WriteLine(line);
                        Login();
                        break;
                    }
                    case 3:
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\t\t(: Thank You for choosing ROAD HOUSE CAFE :)");
                        Console.WriteLine(line);
                        break;
                    }
                    default:
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\t\t Invalid Option Please Try Again");
                        Console.WriteLine(line);
                        //Register();
                        break;
                    }
                }
            }while(mainMenuOption != 3);
        }//MainMenu Ends
        //Register
        public static void Register()
        {
            //Need to get user details
            Console.Write("\nEnter your name -> ");
            string userName = Console.ReadLine();
            Console.Write("\nEnter your Father name -> ");
            string fatherName = Console.ReadLine();
            Console.Write("\nEnter your Mobile No. -> ");
            long mobileNo = Convert.ToInt64(Console.ReadLine());
            Console.Write("\nEnter your Mail ID -> ");
            string mailID = Console.ReadLine();
            Console.Write("\nSelect your Gender [Male | Female] -> ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write("\nEnter your Workstation No. -> ");
            string workStation = Console.ReadLine();
            Console.Write("\nEnter any amount for Wallet [Minimum Rs. 50] -> ");
            double balance = Convert.ToDouble(Console.ReadLine());

            //Need to create object and add the user details to the list
            UserDetails user = new UserDetails(userName,fatherName,gender,mobileNo,mailID,workStation,balance);
            userList.Add(user);
            //After the successfull registration, need to display the User ID
            Console.WriteLine(line);
            Console.WriteLine($"\n\tUser Registration Successfully Completed\n\tYour User ID -> {user.UserID}");  
        }//Registration Ends
        //Login
        public static void Login()
        {
            //Need to get User ID 
            Console.Write("Enter User ID -> ");
            string loginID = Console.ReadLine().ToUpper();
            //Validate the user ID
            bool isValidUser = true;
            foreach(UserDetails users in userList)
            {
                if(users.UserID.Equals(loginID))
                {
                    isValidUser = false;
                    currentLoggedUser = users;
                    Console.Write("<--------- Login Successfull !! --------->\n");
                    SubMenu();
                    break;
                }
            }
            if(isValidUser)
            {
                Console.WriteLine("<--------- Invalid User ID !! --------->");
            }
        }//Login Ends
        //SubMenu
        public static void SubMenu()
        {
            string subOption;
            do{
                //Need to show the submenu for user
                Console.Write(line);
                Console.WriteLine("\n\t***** Sub-Menu *****");
                Console.Write(line);
                Console.WriteLine("\na. Show My Profile\nb. Order Food\nc. Modify Order\nd. Cancel Order\ne. Order History\nf. Wallet Recharge\ng. Show Wallet Balance\nh. Back to MainMenu\nSelect any option to proceed -> ");
                //Need to get the submenu option from the user
                subOption = Console.ReadLine().ToLower();
                switch(subOption)
                {
                    case "a":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine($"\n\t\t {currentLoggedUser.Name}'s Profile");
                        Console.WriteLine(line);
                        ShowMyProfile();
                        break;
                    }
                    case "b":
                    {
                        // Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t Food Order");
                        Console.WriteLine(line);
                        //Calling FoodOrder Method
                        FoodOrder();
                        break;
                    }
                    case "c":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t Modify Order");
                        Console.WriteLine(line);
                        //Calling ModifyOrder Method
                        ModifyOrder();
                        break;
                    }
                    case "d":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t Cancel Order");
                        Console.WriteLine(line);
                        //Calling CancelOrder Method
                        CancelOrder();
                        break;
                    }
                    case "e":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t Order History");
                        Console.WriteLine(line);
                        //Calling Order History
                        OrderHistory();
                        break;
                    }
                    case "f":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t Wallet Recharge");
                        Console.WriteLine(line);
                        //Calling a method
                        WalletRecharge();
                        break;
                    }
                    case "g":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t Wallet Balance");
                        Console.WriteLine(line);
                        //Calling a method
                        ShowWalletBalance();
                        break;
                    }
                    case "h":
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t\t Going back to MainMenu");
                        break;
                    }
                    default:
                    {
                        Console.Clear();
                        Console.WriteLine(line);
                        Console.WriteLine("\n\t Invalid Option.. Please Choose b/w [a - h]");
                        Console.WriteLine(line);
                        break;
                    }
                }
            }while(subOption != "h");
        }//SubMenu Ends
        //a. ShowMyProfile
        public static void ShowMyProfile()
        {
            //Need to show the current logged user's personal details
            Console.WriteLine($"| {"User ID",8} | {"UserName",12} | {"Father Name",12} | {"Mobile No",12} | {"Mail ID",18} | {"Gender",10} | {"WorkStation No",12} | {"Balance",8} |");
            Console.WriteLine($"| {currentLoggedUser.UserID,8} | {currentLoggedUser.Name,12} | {currentLoggedUser.FatherName,12} | {currentLoggedUser.Mobile,12} | {currentLoggedUser.MailID,18} | {currentLoggedUser.Gender,10} | {currentLoggedUser.WorkStationNumber,14} | {currentLoggedUser.WalletBalance,8} |");
        }//ShowMyProfile Ends
        //b. Food Order
        public static void FoodOrder()
        {
            //Need to create temporary cartItemList
            CustomList<CartItem> tempCartItem = new CustomList<CartItem>(); //Local List
            //Need to create object for orderDetails
            OrderDetails order1 = new OrderDetails(currentLoggedUser.UserID,DateTime.Now,0,OrderStatus.Initiated);
            string userOption;
            do{
                //Need to show all the available food list
                Console.WriteLine($"| {"Food ID",-8} | {"Food Name",-10} | {"Price",-7} | {"Available Quantity",-18} |");
                foreach (FoodDetails foods in foodList)
                {
                    Console.WriteLine(line);
                    Console.WriteLine($"| {foods.FoodID,-8} | {foods.FoodName,-10} | {foods.FoodPrice,-7} | {foods.AvailableQuantity,-18} |");
                }
                //Ask the user to select food using foodID
                Console.Write("Please enter Food ID -> ");
                string userFoodID = Console.ReadLine().ToUpper();
                
                //Ask the user to select food quantity
                Console.Write("Please enter Food Quantity -> ");
                int userFoodQty = int.Parse(Console.ReadLine());
                // If the food and quantity available, reduce the quantity from the food object’s “AvailableQuantity”
                bool isNotAvailable = true;
                foreach (FoodDetails foods in foodList)
                {
                    if(foods.FoodID.Equals(userFoodID) && foods.AvailableQuantity >= userFoodQty)
                    {
                        //reducing the quantity
                        foods.AvailableQuantity -= userFoodQty;
                        isNotAvailable = false;
                        //then create CartItems object using the available data.
                        CartItem wishList = new CartItem(order1.OrderID,userFoodID,foods.FoodPrice*userFoodQty,userFoodQty);
                        tempCartItem.Add(wishList);
                        break;
                    }
                } 
                if(isNotAvailable)
                {
                    Console.WriteLine("Invalid Food ID or No quantity available");
                }
                    // } 
                // }
                
                //Ask the user whether he/she wants to continue
                Console.Write("Do you want to pick another product? [yes | no] -> ");
                userOption = Console.ReadLine().ToLower();
            }while(userOption.Equals("yes"));
            string confirmOrder;
            double grandTotal = 0;
            string askRecharge;
            if(userOption.Equals("no"))
            {
                //Ask the user whether he confirms the order
                Console.Write("Do you want to place this order? [yes | No] -> ");
                confirmOrder = Console.ReadLine().ToLower();
                //If he confirms
                if(confirmOrder.Equals("yes"))
                {
                    foreach(CartItem products in tempCartItem)
                    {
                        grandTotal += products.OrderPrice;
                    }
                    //Check whether user has sufficient balance in wallet
                    if(currentLoggedUser.WalletBalance >= grandTotal)
                    {
                        //Deducting grandtotal from user wallet
                        currentLoggedUser.DeductAmount(grandTotal);
                        //Adding Local cartItems to the Original CartItemList
                        cartList.AddRange(tempCartItem);
                        //Modifying already created orderDetails object and adding it to the orderList
                        order1.TotalPrice += grandTotal;
                        order1.OrderStatus = OrderStatus.Ordered;
                        orderList.Add(order1);
                        Console.WriteLine(line);
                        Console.WriteLine($"\t\t***** Your Order Placed Successfully *****\n\t\tYour OrderID -> {order1.OrderID}");
                    }
                    else
                    {
                        Console.Write("\nSeems like you don't have enough balance to place the order\nDo you want to recharge your wallet? [yes | no] -> ");
                        askRecharge = Console.ReadLine().ToLower();
                        if(askRecharge.Equals("yes"))
                        {
                            Console.WriteLine($"\nYour Current Wallet Balance -> Rs.{currentLoggedUser.WalletBalance}\nYour Order Total -> Rs.{grandTotal}\nAmount needed to proceed with the order Rs.{grandTotal - currentLoggedUser.WalletBalance}");
                            Console.Write("Enter recharge amount -> ");
                            double rechargeAmount = Convert.ToDouble(Console.ReadLine());
                            currentLoggedUser.WalletRecharge(rechargeAmount);
                            Console.WriteLine("Recharge Successfull");
                            //Deducting grandtotal from user wallet
                            currentLoggedUser.DeductAmount(grandTotal);
                            //Adding Local cartItems to the Original CartItemList
                            cartList.AddRange(tempCartItem);
                            //Modifying already created orderDetails object and adding it to the orderList
                            order1.TotalPrice += grandTotal;
                            order1.OrderStatus = OrderStatus.Ordered;
                            orderList.Add(order1);
                            Console.WriteLine(line);
                            Console.WriteLine("\t\t***** Your Order Placed Successfully *****");
                        }
                        else
                        {
                            Console.WriteLine("Exiting without Order due to insufficient balance");
                            foreach (FoodDetails foods in foodList)
                            {
                                foreach (CartItem items in tempCartItem)
                                {
                                    if(foods.FoodID.Equals(items.FoodID))
                                    {
                                        foods.AvailableQuantity += items.OrderQuantity;
                                    }
                                }
                            }
                        }
                    }
                }
                else if(confirmOrder.Equals("no"))
                {
                    foreach (FoodDetails foods in foodList)
                    {
                        foreach (CartItem items in tempCartItem)
                        {
                            if(foods.FoodID.Equals(items.FoodID))
                            {
                                foods.AvailableQuantity += items.OrderQuantity;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    FoodOrder();
                }
            }
        }//FoodOrder Ends
        //c. Modify Order
        public static void ModifyOrder()
        {
            //Need to show the order details of current user
            Console.WriteLine($"| {"Order ID",-8} | {"User ID",-8} | {"Order Date",-12} | {"TotalPrice",-10} | {"Order Status",-12} |");
            bool isOrderFound = true;
            foreach (OrderDetails orders in orderList)
            {
                if(orders.UserID.Equals(currentLoggedUser.UserID) && orders.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    isOrderFound = false;
                    Console.WriteLine($"| {orders.OrderID,-8} | {orders.UserID,-8} | {orders.OrderDate.ToString("dd/MM/yyyy"),-12} | {orders.TotalPrice,-10} | {orders.OrderStatus,-12} |");
                }
            }
            //Display order not found if orderDetails doesn't contains userID
            if(isOrderFound)
            {
                Console.WriteLine("You have no orders to show");
            }
            //Need to get the OrderID from the user
            Console.Write("\nEnter OrderID to Modify -> ");
            string modifyOrderID = Console.ReadLine().ToUpper();
            //Need to show the CartItemList and get the ItemID from the User
            Console.WriteLine($"| {"Item ID",-8} | {"Order ID",-8} | {"Food ID",-8} | {"OrderPrice",-10} | {"Order Quantity",-14} |");
            foreach (CartItem item in cartList)
            {
                if(item.OrderID.Equals(modifyOrderID)){
                    Console.WriteLine(line);
                    Console.WriteLine($"| {item.ItemID,-8} | {item.OrderID,-8} | {item.FoodID,-8} | {item.OrderPrice,-10} | {item.OrderQuantity,-14} |");
                }
            }
            Console.Write("\nEnter Item ID to Modify the Order -> ");
            string modifyItemID = Console.ReadLine().ToUpper();
            //Ensure that given Item ID is valid
            int oldQuantity;
            double oldOrderPrice = 0;
            double newOrderPrice;
            foreach (CartItem item in cartList)
            {
                if(modifyItemID.Equals(item.ItemID) && modifyOrderID.Equals(item.OrderID))
                {
                    //Ask new quantity of food from user
                    Console.Write("\nEnter New Quantity to Modify -> ");
                    int newQuantity = int.Parse(Console.ReadLine());
                    oldQuantity = item.OrderQuantity;
                    item.OrderQuantity = newQuantity;
                    foreach (FoodDetails food in foodList)
                    {
                        if(item.ItemID.Equals(modifyItemID) && item.FoodID.Equals(food.FoodID))
                        //Updating the orderPrice
                        oldOrderPrice = item.OrderPrice;
                        item.OrderPrice = food.FoodPrice * newQuantity;
                        newOrderPrice = item.OrderPrice;
                        if(newQuantity < oldQuantity)
                        {
                            food.AvailableQuantity += oldQuantity - newQuantity;
                            //currentLoggedUser.WalletRecharge(oldOrderPrice-newOrderPrice);
                        }
                        else{
                            food.AvailableQuantity -= newQuantity - oldQuantity;
                            //currentLoggedUser.DeductAmount(newOrderPrice - oldOrderPrice);
                        } 
                    }
                }
            }
            //Get modified new totalPrice
            double newGrandTotal = 0;
            foreach (CartItem item in cartList)
            {
                if(modifyOrderID.Equals(item.OrderID))
                {
                    newGrandTotal += item.OrderPrice;
                }
            }
            //Update the TotalPrice in OrderDetails
            foreach (OrderDetails orders in orderList)
            {
                if(orders.OrderID.Equals(modifyOrderID))
                {
                    orders.TotalPrice = newGrandTotal;
                    Console.WriteLine("\n\t********** Order Modified Successfully **********");
                    break;
                }
            }

        }//ModifyOrder Ends 
        //d. Cancel Order
        public static void CancelOrder()
        {
            //Need to show the order details of current user
            Console.WriteLine($"| {"Order ID",-8} | {"User ID",-8} | {"Order Date",-12} | {"TotalPrice",-10} | {"Order Status",-12} |");
            bool isOrderFound = true;
            foreach (OrderDetails orders in orderList)
            {

                if(orders.UserID.Equals(currentLoggedUser.UserID) && orders.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    isOrderFound = false;
                    Console.WriteLine($"| {orders.OrderID,-8} | {orders.UserID,-8} | {orders.OrderDate.ToString("dd/MM/yyyy"),-12} | {orders.TotalPrice,-10} | {orders.OrderStatus,-12} |");
                }
            }
            //Display order not found if orderDetails doesn't contains userID
            if(isOrderFound)
            {
                Console.WriteLine("You have no orders to show");
            }
            //Ask the user to choose order ID, which user wants to cancel
            Console.Write("Enter an Order ID to Cancel the order -> ");
            string cancelOrderID = Console.ReadLine();
            //Validate whether the order ID is correct
            foreach (OrderDetails orders in orderList)
            {
                if(orders.OrderID.Equals(cancelOrderID))
                {
                    //Refunding the total amount to the user
                    currentLoggedUser.WalletRecharge(orders.TotalPrice);
                    foreach (FoodDetails foods in foodList)
                    {
                        foreach (CartItem items in cartList)
                        {
                            if(items.OrderID.Equals(cancelOrderID) && items.FoodID.Equals(foods.FoodID))
                            {
                                foods.AvailableQuantity += items.OrderQuantity;
                                orders.OrderStatus = OrderStatus.Cancelled;
                                Console.WriteLine(line);
                                Console.WriteLine($"\t\t Order {cancelOrderID} cancelled successfully");
                            }
                        }
                        
                    }
                    break;
                }
            }

        }//CancelOrder Ends      
        //e. OrderHistory
        public static void OrderHistory()
        {
            //Need to show the order details of current user
            Console.WriteLine($"| {"Order ID",-8} | {"User ID",-8} | {"Order Date",-12} | {"TotalPrice",-10} | {"Order Status",-12} |");
            bool isOrderFound = true;
            foreach (OrderDetails orders in orderList)
            {

                if(orders.UserID.Equals(currentLoggedUser.UserID))
                {
                    isOrderFound = false;
                    Console.WriteLine($"| {orders.OrderID,-8} | {orders.UserID,-8} | {orders.OrderDate.ToString("dd/MM/yyyy"),-12} | {orders.TotalPrice,-10} | {orders.OrderStatus,-12} |");
                }
            }
            //Display order not found if orderDetails doesn't contains userID
            if(isOrderFound)
            {
                Console.WriteLine("You have no orders to show");
            }
        }//OrderHistory Ends
        //f. WalletRecharge
        public static void WalletRecharge()
        {
            //Need to get the recharge amount from the user
            Console.Write("Enter Recharge Amount -> ");
            double amount = Convert.ToDouble(Console.ReadLine());
            //Need to add the recharge amount to the wallet
            currentLoggedUser.WalletRecharge(amount);
            Console.WriteLine($"\n Recharge Done Successfully for Rs. {amount}");
        }//WalletRecharge Ends 
        //g. ShowWalletBalance
        public static void ShowWalletBalance()
        {
            Console.Write($"\n\tWallet Balance : {currentLoggedUser.WalletBalance}\n");
        }//ShowWalletBalance Ends
        //Adding Default Data
        public static void DefaultData()
        {
            //Creating object reference
            UserDetails user1 = new UserDetails("Ragnar", "Odin", Gender.Male, 8857777575, "ragnar@gmail.com", "WS101", 400);
            UserDetails user2 = new UserDetails("Bjorn", "Ragnar", Gender.Male, 9896677575, "bjorn@gmail.com", "WS105", 500);
            //Adding users to the list
            userList.Add(user1);
            userList.Add(user2);

            //creating object for FoodDetails
            FoodDetails food1 = new FoodDetails("Coffee",20,100);
            FoodDetails food2 = new FoodDetails("Tea",15,100);
            FoodDetails food3 = new FoodDetails("Biscuit",10,100);
            FoodDetails food4 = new FoodDetails("Juice",50,100);
            FoodDetails food5 = new FoodDetails("Puffs",40,100);
            FoodDetails food6 = new FoodDetails("Milk",10,100);
            FoodDetails food7 = new FoodDetails("Popcorn",20,20);
            //Adding foods to the list
            foodList.Add(food1);
            foodList.Add(food2);
            foodList.Add(food3);
            foodList.Add(food4);
            foodList.Add(food5);
            foodList.Add(food6);
            foodList.Add(food7);

            //Creating object for OrderDetails
            OrderDetails order1 = new OrderDetails(user1.UserID, new DateTime(2022,06,15), 70, OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails(user2.UserID, new DateTime(2022,06,15), 100, OrderStatus.Ordered);        
            //Adding orders to the list
            orderList.Add(order1);
            orderList.Add(order2);

            //creating object for CartItems
            CartItem cart1 = new CartItem(order1.OrderID,food1.FoodID,food1.FoodPrice,1);
            CartItem cart2 = new CartItem(order1.OrderID,food3.FoodID,food3.FoodPrice,1);
            CartItem cart3 = new CartItem(order1.OrderID,food5.FoodID,food5.FoodPrice,1);
            CartItem cart4 = new CartItem(order2.OrderID,food3.FoodID,food3.FoodPrice,1);
            CartItem cart5 = new CartItem(order2.OrderID,food4.FoodID,food4.FoodPrice,1);
            CartItem cart6 = new CartItem(order2.OrderID,food5.FoodID,food5.FoodPrice,1);
            //Adding cart items to the list
            cartList.Add(cart1);
            cartList.Add(cart2);
            cartList.Add(cart3);
            cartList.Add(cart4);
            cartList.Add(cart5);
            cartList.Add(cart6);

            // foreach(CartItem cart in cartList)
            // {
            //     Console.WriteLine($"\n| {cart.ItemID,12} | {cart.OrderID,12} | {cart.FoodID,12} | {cart.OrderPrice,12} | {cart.OrderQuantity,12} |");
            // }
        }
    }
}