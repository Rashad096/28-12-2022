using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _28._12._2022AccessModifiers
{
    internal class Notebook:Product
    {
        public Notebook(string name,double price):base(name,price)
        {

        }

        public Notebook(string name,double price,byte ram):base(name,price)
        {
            RAM = ram;

        }

        public byte RAM;


        public override string GetInfo()
        {
            string baseInfo = base.GetInfo();
            return $"{baseInfo}  RAM:{RAM}";
        }
    }

   
}
