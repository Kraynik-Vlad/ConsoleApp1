using System;
using ConsoleApp1.Entity;
using System.Collections.Generic;
using ConsoleApp1.Services;

namespace ConsoleApp1
{
    class Program
    {
        private static object users;

        //TODO: todo


        static void Main(string[] args)
        {
            //StoreService store = new StoreService();
            //store.getAllGoods();

            
            
             new Store(new User("Guest", "", role.GUEST.ToString())).run();
        }

       
    }

/*public void addOrder(Order order)
{
    this.order.Add(order);
}
*/
}


