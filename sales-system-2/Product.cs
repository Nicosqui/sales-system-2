using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system
{
    class Product
    {
        public String Name;
        public int Price;

        public void ProductStatus()
        {
            Console.WriteLine("Name: {0}, Price: {1}", Name, Price);
        }
    }
}
