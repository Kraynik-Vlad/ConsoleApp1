using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entity
{
    public class GoodForOrder
    {
        private string name;
        private int amountInOrder;

        public GoodForOrder(string name, int amountInOrder)
        {
            this.name = name;
            this.amountInOrder = amountInOrder;

        }
        public int AmountInOrder()
        {
            return amountInOrder;
        }
        public string getName()
        {
            return name;
        }

    }
}
