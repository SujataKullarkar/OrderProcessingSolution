using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSolution
{
    public class OrderService : IOrderService
    {
        public void GetPrice(Product product)
        {
            product.Price = product.Id switch
            {
                "A" => 50m,
                "B" => 30m,
                "C" => 20m,
                "D" => 15m,
                _ => product.Price
            };
        }

        public int GetOrderAmount(List<Product> products)
        {
            int aTotalProducts = 0, bTotalProducts = 0, cTotalProducts = 0, dTotalProducts = 0;
            int aPrice = 50, bPrice = 30, cPrice = 20, dPrice = 15;

            foreach (Product pr in products)
            {
                switch (pr.Id)
                {
                    case "A":
                        aTotalProducts += 1;
                        break;
                    case "B":
                        bTotalProducts += 1;
                        break;
                    case "C":
                        cTotalProducts += 1;
                        break;
                    case "D":
                        dTotalProducts += 1;
                        break;
                }
            }
            int totalPriceOfA = (aTotalProducts / 3) * 130 + (aTotalProducts % 3 * aPrice);
            int totalPriceOfB = (bTotalProducts / 2) * 45 + (bTotalProducts % 2 * bPrice);
            int totalPriceOfCD;

            // C + D = 30
            if (cTotalProducts >= dTotalProducts) 
            {
                //  C = 5 & D = 4 => 1 * 20 + 30 * 4 = 140
                //  C = 1 & D = 1 => 0 * 20 + 30 * 1 = 30
                totalPriceOfCD = (cTotalProducts - dTotalProducts) * cPrice + 30 * dTotalProducts;
            }
            else
            {
                // C = 2  & D = 5 =>  3 * 15 + 30 * 2 = 90
                // C = 0  & D = 1 =>  1 * 15 = 15
                totalPriceOfCD = (dTotalProducts - cTotalProducts) * dPrice + 30 * cTotalProducts;
            }

            return totalPriceOfA + totalPriceOfB + totalPriceOfCD;
        }
    }
}
