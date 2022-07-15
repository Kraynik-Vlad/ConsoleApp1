using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Entity;

namespace ConsoleApp1.Services
{
    public class StoreService
    {
        /*
        private Good good = new Good("milk", 20);
        private Good good1 = new Good("aplle", 15);
        private Good goog2 = new Good("potato", 25);
        private Good good3 = new Good("cheese", 40);
        private Good good4 = new Good("vine", 50);
        */
        //List<Good> goods = new List<Good>();

        // Создать конструктор, туда создать list и туда запихать все сверху

        List<Good> goods = new List<Good>();
        

        public StoreService()
        {
            goods.Add(new Good("milk", 20));
            goods.Add(new Good("apple", 15));
            goods.Add(new Good("potato", 25));
            goods.Add(new Good("cheese", 40));
            goods.Add(new Good("vine", 50));
        }
        
        
        

        public void getAllGoods()
        {
            for (int i = 0; i < goods.Count; i++)
            {
                Console.WriteLine(goods[i].getName());
                Console.WriteLine(goods[i].getAmointInStorage());
            }

            // Два Консоль лог переделать в один который еще делает таблицу. гугли как рамки рисовать баклан
        }

        public void getGoodByName(string name)
        {
            bool n = false;

            for (int i = 0; i < goods.Count; i++)
            {
                if (name.Equals(goods[i].getName()))
                {
                    n = true;
                    Console.WriteLine(n);
                    Console.WriteLine(goods[i].getName());
                }
            }
            if (n == false)
            {
                Console.WriteLine("There is no goods");
            }
            
            // создать цикл по колекции, который виводит товар по названию(запрошеному пользователем),
            // которое совпадает с названием в коллекции
            // если товар не найден - пишем что такого товара нету
        }

    }
}
