using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entity
{
    public class Order
    {
        private int id;
        private string status;
        private List<Good> goods = new List<Good>();
                
        public Order()
        {
            this.id = generateId();
            this.status = ActionEnum.New.ToString();
        }

        private int generateId()
        {

            return new Random().Next(10001);
        }

        public void addGood(Good good)
        {
            this.goods.Add(good);
        }
    }
}
