using sales_system_2;
using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            int Total = 0;

            Store store = new Store();

            SalesMan v1 = new SalesMan();
            v1.Name = "Carlos";
            v1.Age = 30;
            store.AddSalesMan(v1);

            SalesMan v2 = new SalesMan();
            v2.Name = "Juan";
            v2.Age = 30;
            store.AddSalesMan(v2);

            SalesMan v3 = new SalesMan();
            v3.Name = "Alberto";
            v3.Age = 30;
            store.AddSalesMan(v3);

            Product p1 = new Product();
            p1.Name = "Computer";
            p1.Price = 500;
            store.AddProduc(p1);

            Product p2 = new Product();
            p2.Name = "Keyboard";
            p2.Price = 50;
            store.AddProduc(p2);

            Product p3 = new Product();
            p3.Name = "Monitor";
            p3.Price = 100;
            store.AddProduc(p3);

            Sale s1 = new Sale();
            s1.SalesMan = v1;
            s1.Product = p1;
            s1.Comments = "Good seller and great product";
            store.AddSale(s1);

            Sale s4 = new Sale();
            s4.SalesMan = v2;
            s4.Product = p1;
            s4.Comments = "Good seller and great product";
            store.AddSale(s4);

            Sale s2 = new Sale();
            s2.SalesMan = v2;
            s2.Product = p2;
            s2.Comments = "Good seller and great product";
            store.AddSale(s2);

            Sale s3 = new Sale();
            s3.SalesMan = v3;
            s3.Product = p3;
            s3.Comments = "Good seller and great product";
            store.AddSale(s3);

            //Calculate sales total amount

            Total = p1.Price+p2.Price+p3.Price;

           
            System.Console.WriteLine("The total amount of sales is: " + Total);

            Console.WriteLine("\nProducts");
            store.printProducts();
            Console.WriteLine("\nSalesMan");
            store.printSalesMan();
            Console.WriteLine("\nSales");
            store.printSales();

            Console.WriteLine("\nSales Man That Sold The Cheapest Product: ");
            store.sellerThatSoldCheapestProduct().salesManStatus();

            Console.WriteLine("\nAverage Products Price: ");
            Console.WriteLine(store.averageProductsPrice());

            Console.WriteLine("\nNumber Sells by seller: ");
            store.printNumberSellsBySalesMan();

            Console.WriteLine("\nThe most expensive product: ");
            store.MostExpensiveProduct().ProductStatus();
        }
    }       
}
