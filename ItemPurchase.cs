using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleTestApp.CollectionClass
{
    class ItemPurchase
    {
        public static void Main()
        {
            Hashtable products = new Hashtable();
            Hashtable cart = null;

            int option;

            products.Add(101,new Product{ ProductId = 101, ProductName   = "Yardly      ", UnitPrice=25,Quantity=0,Amount=0});
            products.Add(102, new Product { ProductId = 102, ProductName = "Indulekha   ", UnitPrice = 30, Quantity = 0, Amount = 0 });
            products.Add(103, new Product { ProductId = 103, ProductName = "Nice        ", UnitPrice = 10, Quantity = 0, Amount = 0 });
            products.Add(104, new Product { ProductId = 104, ProductName = "No1         ", UnitPrice = 10, Quantity = 0, Amount = 0 });
            products.Add(105, new Product { ProductId = 105, ProductName = "Chandrekha  ", UnitPrice = 20, Quantity = 0, Amount = 0 });

            do
            {
                Console.WriteLine("******************************************************************");
                Console.WriteLine("1.ADD CART");
                Console.WriteLine("2.VIEW CART");
                Console.WriteLine("3.CHECKOUT CART");
                Console.WriteLine("4.EXIT");
                Console.WriteLine("******************************************************************");
                Console.WriteLine("Enter the option from (1-4?)");
                Console.WriteLine("******************************************************************");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("******************************************************************");
                        Console.WriteLine("                 Product Details");
                        Console.WriteLine("******************************************************************");
                        Console.WriteLine("Product ID| Product Name |Unit Price");
                        Console.WriteLine("******************************************************************");
                        Product product;
                        if (products != null)
                        {
                            ICollection key = products.Keys;
                            foreach(int k in key)
                            {
                                product = ((Product)products[k]);
                                Console.WriteLine(product.ProductId + "  |" + product.ProductName + "            |" + product.UnitPrice);
                            }

                        }
                        else
                        {
                            Console.WriteLine("No products availble in the cart");
                        }
                        Console.WriteLine("******************************************************************");
                        
                        Console.WriteLine("Enter the Product ID");
                        int product_id = Convert.ToInt32(Console.ReadLine());
                     
                        Console.WriteLine("Enter the Quantity");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        if (cart == null)
                        {
                            cart = new Hashtable();
                        }
                        product = (Product)products[product_id];
                        product.Quantity = quantity;
                        product.Amount = product.UnitPrice * product.Quantity;
                        cart.Add(product_id, product);
                        Console.WriteLine("product Successfully added to cart");


                        break;
                    case 2:
                        Console.WriteLine("******************************************************************");
                        Console.WriteLine("                   Product Details");
                        Console.WriteLine("******************************************************************");
                        Console.WriteLine("Product ID   | Product Name  |Unit Price   |Quantity|Amount       ");
                        Console.WriteLine("******************************************************************");

                        if (cart != null)
                        {
                            ICollection key = cart.Keys;
                            foreach (int k in key)
                            {
                                product = ((Product)products[k]);
                                Console.WriteLine(product.ProductId + "  |" + product.ProductName + "          |" + product.UnitPrice + "     |" + product.Quantity + " |" + product.Amount);
                            }

                        }
                        else
                        {
                            Console.WriteLine("No products availble in the cart");
                        }



                        break;
                    case 3:

                        int total=0;
                        Console.WriteLine("******************************************************************");
                        Console.WriteLine("                 Product Purchased");
                        Console.WriteLine("******************************************************************");
                        Console.WriteLine("Product ID   | Product Name  |Unit Price   |Quantity|Amount       ");
                        Console.WriteLine("******************************************************************");

                        if (cart != null)
                        {
                            ICollection key = cart.Keys;
                            foreach (int k in key)
                            {
                                product = ((Product)cart[k]);
                                Console.WriteLine(product.ProductId + "  |" + product.ProductName + "          |" + product.UnitPrice + "     |" + product.Quantity + " |" + product.Amount);
                                
                                total += product.Amount;

                            }
                            Console.WriteLine("__________________________________________________________________");
                            Console.WriteLine("------------------------------------------------Total Amount:{0}",total);
                            Console.WriteLine("****************************THANKYOU******************************");



                        }
                        else
                        {
                            Console.WriteLine("Your haven't purchased any item");
                        }
                       




                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }






            } while (true);








        }

       
        
    }
    class Product
    {
        public int ProductId {get; set;}
        public string ProductName {get; set;}
        public int UnitPrice {get; set;}
        public int Quantity {get; set;}
        public int Amount {get; set;}

        




    }
}
