using System;
using System.Collections.Generic;
using System.Text;

namespace _28._12._2022AccessModifiers
{
    internal class Product
    {

        public Product(string name,double price)
        {
            Name = name;
            Price = price;
        }

        public string Name;
        public double Price;


        public virtual string GetInfo()
        {
            return $"Name: {Name} Price: {Price} ";
         }
    }

    
}
