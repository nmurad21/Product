using System;
using Product.Moduls;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Book kitab = new Book("Kevin Brown", 79, 15, "kitab", 15, 100);
            kitab.GetInfo();
            Console.WriteLine(kitab.GetDiscountedPrice());
        }
    }
}


