using System;
using System.Collections.Generic;

namespace OrderProcessingSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            IOrderService orderService = new OrderService();

            Console.WriteLine("Total Products in Order");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the Product Name : A, B, C or D");
                string type = Console.ReadLine();

                Product p = new Product(type);
                orderService.GetPrice(p);
                products.Add(p);
            }

            int totalPrice = orderService.GetOrderAmount(products);
            Console.WriteLine("Order Value is Rs. " + totalPrice);
            Console.ReadLine();
        }
    }
}
