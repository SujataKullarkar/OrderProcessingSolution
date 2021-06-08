using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSolution
{
    public interface IOrderService
    {
        void GetPrice(Product product);
        int GetOrderAmount(List<Product> products);
    }
}
