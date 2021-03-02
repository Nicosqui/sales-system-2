using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system
{
    class SalesMan
    {
        public String Name;
        public byte Age;
        public int NumberSells;

        public void salesManStatus()
        {
            Console.WriteLine("Name: {0}, Age: {1}", Name, Age);
        }

        public void salesManStatusBySells()
        {
            Console.WriteLine("Name: {0}, Number Sells: {1}", Name, NumberSells);
        }
    }
}
