using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system
{
    class Sale
    {
        public Product Product;
        public SalesMan SalesMan;
        public String Comments;

        public void saleStatus()
        {
            Console.WriteLine("Product Name: {0}, SalesMan: {1}, Comments: {2}", Product.Name, SalesMan.Name, Comments);
        }

        public void saleStatusForSellsBySeller()
        {
            Console.WriteLine("SalesMan: {0}, Number Sells: {2}", SalesMan.Name, Comments);
        }
    }
}
