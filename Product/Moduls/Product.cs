using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Moduls
{
    class Product 
    {
        public string name;
        public double costPrice;
        public double saledPrice;

        public Product(string name, double costPrice, double saledPrice)
        {
            this.name = name;
            this.costPrice = costPrice;
            this.saledPrice = saledPrice;
        }
    }  
}
