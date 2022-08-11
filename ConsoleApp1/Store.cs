using ConsoleApp1.Entity;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Store
    {
        private User activeUser;
        UserService userService = new UserService();
        StoreService storeService = new StoreService();
        Order order = new Order();


        public Store(User activeUser)
        {
            this.activeUser = activeUser;

        }

        public void test() { 
        
        
        }

        public void run()
        {
            String s = "";


            while (true)
            {
                Console.Write("Hello, ");
                Console.WriteLine(this.activeUser.getLogin());
                Console.WriteLine("Welcome to our store!");

                if (s.Equals(""))
                {
                    s = getScreen();
                }
                
                /*
                 * ----- GUEST menu activity --------------
                */
                if (s.Equals("1") && activeUser.getRole().Equals(role.GUEST.ToString()))
                {
                    searchForGoodsByName();
                }
                // user account registration;
                else if (s.Equals("2") && activeUser.getRole().Equals(role.GUEST.ToString()))
                {
                    User user = registration();
                    // users.Add(user);
                }

                else if (s.Equals("3") && activeUser.getRole().Equals(role.GUEST.ToString()))
                {
                    login();    
                }
                /*
                 * ---- END GUEST menu activity ------
                */


                /*
                 *  ---- REGISTERED_USER menu activity ------
                */
                else if (s.Equals("1") && activeUser.getRole().Equals(role.REGISTERED_USER.ToString()))
                {
                    viewTheListOfGoods();
                }
                else if (s.Equals("2") && activeUser.getRole().Equals(role.REGISTERED_USER.ToString()))
                {
                    searchForGoodsByName();
                }
                else if (s.Equals("3") && activeUser.getRole().Equals(role.REGISTERED_USER.ToString()))
                {
                    Order order = new Order();
                    order = CreatingANewOrder(order);
                    if (order.getGoods().Count > 0)
                    {
                        activeUser.addOrder(order);
                    }
                   
                }
                
                /*else if (s.Equals("3") && activeUser.getRole().Equals(role.REGISTERED_USER.ToString()))
                {

                }
                */
                // todo REGISTERED_USER menu
                // else if

                /*
                 * ---- END REGISTERED_USER menu activity ------ 
                */
                if (s.Equals("0"))
                {
                    Environment.Exit(0);
                }

                s = "";
                Console.Clear();
            }
        }

        private String getScreen()
        {
            String s = "";
            if (activeUser.getRole().Equals(role.GUEST.ToString()))
            {
                s = guestScreen();
            }
            else
            {
                s = userScreen();
            }
            return s;

        }

        private static String guestScreen()
        {
            Console.WriteLine();
            Console.WriteLine("Please choose one option:");
            Console.WriteLine("1. Search for goods by name");
            Console.WriteLine("2. Registration");
            Console.WriteLine("3. Login");
            Console.WriteLine();
            Console.WriteLine("0. Exit from store");
            return Console.ReadLine();
        }

        private void viewTheListOfGoods()
        {
            Console.WriteLine("This is all goods!");
            storeService.getAllGoods();
        }

        private void searchForGoodsByName()
        {
            Console.Clear();
            Console.WriteLine("Write the name of good!");
            string name = Console.ReadLine();
            storeService.PrintGoodByName(name);

            Console.ReadKey();
        }
        private Order CreatingANewOrder(Order order)
        {
            
            Console.Clear();
            Console.WriteLine("What do you want to buy?");
            Console.WriteLine("-----------------");
            viewTheListOfGoods();
            Console.WriteLine("------");
            Console.WriteLine("If you what to exit, press 0 ");
            Console.WriteLine("--");
            Console.WriteLine("Wtite your choice here: ");
            //Console.ReadLine();
            string name = Console.ReadLine();
            if (name.Equals("0"))
            {
                return order;
            }
            Good good = storeService.GetGoodByName(name);
            if (good != null) {
                Console.Write("Please enter amount: ");
                int amountForOrder = Convert.ToInt32(Console.ReadLine());
                if (amountForOrder <= good.getAmointInStorage())
                {
                    GoodForOrder goodForOrder = new GoodForOrder(name, amountForOrder);
                    order.addGood(goodForOrder);
                    Console.WriteLine("Good was add in your Order!");
                    Console.ReadKey();
                    CreatingANewOrder(order);
                }
                else
                {
                    Console.WriteLine("We have not enough Goods!");
                    Console.ReadKey();
                    CreatingANewOrder(order);
                }
            }
            else
            {
                Console.WriteLine("Good was not found!");
                Console.ReadKey();
                CreatingANewOrder(order);
            }

            return order;
            
        }


        private User registration()
        {
            Console.Clear();
            Console.Write("Please write a login: ");
            String username = Console.ReadLine();
            Console.Clear();
            Console.Write("Please write a password: ");
            String password = Console.ReadLine();
            User user = userService.createUser(username, password, role.REGISTERED_USER.ToString());
            Console.Clear();
            Console.WriteLine("User was created");
            Console.ReadKey();
            Console.Clear();
            return user;
        }


        private void login()
        {
            Console.Clear();
            Console.Write("Write login: ");
            String loginName = Console.ReadLine();
            Console.Clear();
            Console.Write("Write password: ");
            String password = Console.ReadLine();
            Console.Clear();
            User user = userService.findUser(loginName, password);
            if (user == null)
            {
                Console.WriteLine("Incorrect login or password");
                Console.ReadKey();
            }
            else
            {
                this.activeUser = user;
                
            }
        }

        private String userScreen()
        {
            // todo screen for registered user 
            Console.Clear();
            Console.WriteLine("Registered User screen");
            Console.WriteLine("1. View the list of goods;");
            Console.WriteLine("2. Search for goods by name;");
            Console.WriteLine("3. Creating a new order;");
            Console.WriteLine("4. Ordering or cancellation;");
            Console.WriteLine("5. Review the history of orders and the status of their delivery;");
            Console.WriteLine("6. Retting the status of the order _Received_;");
            Console.WriteLine("7. Change of personal information;");
            Console.WriteLine("8. Sign out of the account;");
            return Console.ReadLine();

        }
    }
}
