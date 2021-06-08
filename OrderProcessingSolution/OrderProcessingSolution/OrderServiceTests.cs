using System;
using System.Collections.Generic;
using Xunit;

namespace OrderProcessingSolution
{
    public class OrderServiceTests
    {
        List<Product> products370 = new List<Product>() {  
        new Product("A"),
        new Product("A"),
        new Product("A"),
        new Product("A"),
        new Product("A"),

        new Product("B"),
        new Product("B"),
        new Product("B"),
        new Product("B"),
        new Product("B"),

        new Product("C"),
        };
      
       [Fact]
        public void OrderTests_5A_5B_1C_OrderValue_should_be_370()
        {
            // Arrange
            OrderService orderService = new OrderService();

            for (int i = 0; i < products370.Count; i++)
            {
                Console.WriteLine("Enter the Product Name : A, B, C or D");
                string type = Console.ReadLine();

                Product p = new Product(type);
                orderService.GetPrice(p);
                products370.Add(p);
            }

            // Act
            int totalPrice = orderService.GetOrderAmount(products370);

            // Assert
            Assert.True(totalPrice == 370);
        }
    }
}
