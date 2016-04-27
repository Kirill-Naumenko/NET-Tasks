using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
   public class Cashier
    {

        public double getSummaryPrice(Bag bag) //Кассир(или что там в интернет магазине?) принимает корзину и считывает только цену продукта в корзине, независимо от того, что лежит в корзине
        {
            double summaryPrice = 0;
            for (int i = 0; i < bag.bag.Count; i++)
            {
               summaryPrice = summaryPrice + bag.bag[i].getPrice();
            }
            return summaryPrice;
        }

    }
}
