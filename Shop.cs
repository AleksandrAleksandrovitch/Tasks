using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Shop
    {
        public string name;
        public Product[] products;
        public Shop(string n, Product[] a)
        {
            this.name = n;
            this.products = a;
        }

    }
}
