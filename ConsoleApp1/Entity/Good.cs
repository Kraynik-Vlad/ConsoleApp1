using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entity
{
    public class Good
    {
        private string name;
        private int amountInStorage;

        public string getName()
        {
            return name;
        }

        public int getAmointInStorage()
        {
            return amountInStorage;
        }


        public Good(string name, int amountInStorage)
        {
            this.name = name;
            this.amountInStorage = amountInStorage;
        }
  
        public void decreaseAmount(int amountInOrder)
        {
            this.amountInStorage = this.amountInStorage - amountInOrder;
        }
    }
}
