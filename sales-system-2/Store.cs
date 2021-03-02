using sales_system;
using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system_2
{
    class Store
    {
        SalesMan[] SalesMen = new SalesMan[3];
        int salesmenCount = 0;

        Product[] Products = new Product[3];
        int productsCount = 0;

        Sale[] Sales = new Sale[3*3];
        int salesCount = 0;

        public void AddSalesMan(SalesMan newsalesMan)
        {
            SalesMen[salesmenCount] = newsalesMan;
            salesmenCount++;
        }

        public void AddProduc(Product newProduct)
        {
            Products[productsCount] = newProduct;
            productsCount++;
        }

        public void AddSale(Sale newSale)
        {
            Sales[salesCount] = newSale;
            Sales[salesCount].SalesMan.NumberSells++;
            salesCount++;
        }

        //public int CheapestProduct()
        //{z
        //    int count = 0;

        //    for (int i=0)
        //    {

        //    }
        //}

        public void printProducts()
        {
            int i = 0;
            while(i < productsCount) 
            {
                Products[i].ProductStatus();
                i++;
            }
        }

        public void printSales()
        {
            int i = 0;
            while (i < salesCount)
            {
                Sales[i].saleStatus();
                i++;
            }
        }

        public void printSalesMan()
        {
            int i = 0;
            while (i < salesmenCount)
            {
                SalesMen[i].salesManStatus();
                i++;
            }
        }

        public SalesMan sellerThatSoldCheapestProduct()
        {
            SalesMan seller = new SalesMan();
            int temp = Sales[0].Product.Price;
            seller = Sales[0].SalesMan;
            int i = 0;
            while (i<salesCount) {
                if(temp > Sales[i].Product.Price)
                {
                    temp = Sales[i].Product.Price;
                    seller = Sales[i].SalesMan;
                }
                i++;
            }

            return seller;
        }

        public float averageProductsPrice()
        {
            float average;
            int add = 0;

            int i = 0;
            while (i < productsCount)
            {
                add += Products[i].Price;
                i++;
            }
            average = add / productsCount;

            return average;
        }



        public void printNumberSellsBySalesMan()
        {
            int i = 0;
            while (i < salesmenCount)
            {
                SalesMen[i].salesManStatusBySells();
                i++;
            }
        }

        public Product MostExpensiveProduct()
        {
            Product MostExpensive = new Product();
            int temp = Products[0].Price;
            MostExpensive = Products[0];
            int i = 0;
            while (i < productsCount)
            {
                if (temp < Products[i].Price)
                {
                    temp = Products[i].Price;
                    MostExpensive = Products[i];
                }
                i++;
            }

            return MostExpensive;
        }

    }
}
