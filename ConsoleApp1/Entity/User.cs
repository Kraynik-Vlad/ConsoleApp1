using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entity
{
    public class User
    {
        private String login;
        private String password;
        private String role;
       //private String order;
        private List<Order> order = new List<Order>();
        

        public User(string login, string password, string role)
        {
            this.login = login;
            this.password = password;
            this.role = role;
         
        }

        public String getLogin() {
            return this.login;
        }

        public String getPassword() {
            return this.password;
        }

        public String getRole() {
            return this.role;
        }

        public void getOrders()
        {
            //return this.order.ToString();
            for (int i = 1; i < order.Count; i++)
            {
                
                Console.WriteLine(order[i].GetID());
                Console.WriteLine(order[i].getStatus());
            }
            
        }

        public void addOrder(Order order)
        {
            this.order.Add(order);
        }
    }
}
