using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Strings
{
    class ProductProperty
    {
        public static void Main()
        {
            int number;
            Console.WriteLine("Enter the number of products");
            number = Convert.ToInt32(Console.ReadLine());

            Product1[] product = new Product1[number];
            Console.WriteLine("Enter the Product Details");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Product {0}", (i + 1));

                product[i] = new Product1();
                product[i].ReadData();
                Console.WriteLine("Product Id:" + product[i].ProductId);
                Console.WriteLine("Product Name:" + product[i].ProductName);
                Console.WriteLine("Product Price:" + product[i].Price);
                Console.WriteLine("Product Supplier Id:" + product[i].Price);




            }Console.ReadKey();
        }
       
    }
    class Product1
    {
        private string productName;
        private readonly int productId;
        private int price;
        private int supplierId;
        static int start = 101;

        public Product1()
        {
            productId = start;
            start++;
        }
        public void ReadData()
        {
            Console.WriteLine("Enter the Product Name:");
            productName = Console.ReadLine();
            Console.WriteLine("Enter the Product Price:");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Supplier Id:");
            supplierId= Convert.ToInt32(Console.ReadLine());


        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public int ProductId
        {
            get { return productId; }
        }

        public int Price
        {
            get { return price; }
            set {price = value; }
        }

        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }

    }
}
