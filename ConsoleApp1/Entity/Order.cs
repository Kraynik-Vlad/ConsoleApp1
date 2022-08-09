using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entity
{
    public class Order
    {
        private int id;
        private string status;
        private List<GoodForOrder> goods = new List<GoodForOrder>();
                
        public Order()
        {
            this.id = generateId();
            this.status = ActionEnum.New.ToString();
        }

        public int GetID()
        {
            return id;
        }
        public string getStatus()
        {
            return status;
        }


        private int generateId()
        {

            return new Random().Next(10001);
        }

        public void addGood(GoodForOrder good)
        {
            this.goods.Add(good);
        }

        public void printGoods()
        {
            for (int i = 1; i > goods.Count; i++)
            {
                Console.WriteLine(goods[i].AmountInOrder());
                Console.WriteLine(goods[i].getName());
            }
        }
        public List<GoodForOrder> getGoods()
        {
            return goods;
        } 

    }
}
