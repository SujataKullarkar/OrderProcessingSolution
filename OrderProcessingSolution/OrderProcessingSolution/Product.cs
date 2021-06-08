using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSolution
{
    public class Product
    {
        public string Id { get; set; }
        public Product(string id)
        {
            Id = id;
        }
        public decimal Price { get; set; }
    }
}
