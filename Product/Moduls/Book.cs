using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Moduls
{
    class Book:Product
    {
        public string authorName;
        public int pageCount;
        public double discountPercent;
        public Book(string authorName, int pageCount, double discountPercent, string name, double costPrice, double saledPrice) : base(name, costPrice, saledPrice)
        {
            this.authorName = authorName;
            this.pageCount = pageCount;
            this.discountPercent = discountPercent;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{authorName} {pageCount} {discountPercent} {name} {costPrice} {saledPrice}");

        }
        public double GetDiscountedPrice()
        {
            return saledPrice - ((saledPrice * discountPercent) / 100);
        }

    }
}
