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

        public Store(User activeUser)
        {
            this.activeUser = activeUser;
        }

        public void run() {
            String s = "";


            while(true)
            {
                Console.Write("Hello, ");
                Console.WriteLine(this.activeUser.getLogin());
                Console.WriteLine("Welcome to our store!");

                if (s.Equals(""))
                {
                    s = getScreen();
                }
                
                // user account registration;
                if (s.Equals("2") && activeUser.getRole().Equals(role.GUEST.ToString()))
                {
                    User user = registration();
                    // users.Add(user);
                }
                if (s.Equals("3") && activeUser.getRole().Equals(role.GUEST.ToString()))
                {
                    login();
                }
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
            else {
                this.activeUser = user;
            }
        }


        
        private String userScreen() {
            // todo screen for registered user 
            Console.Clear();
            Console.WriteLine("Registered User screen");
            return Console.ReadLine();
        }
    }
}
