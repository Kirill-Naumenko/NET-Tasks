using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Product  //Пусть будет только класс продукт с полем ЦЕНА. Если понадобиться создать продукт КОЛБАСА или НОУТБУК и тд. , то он будет наследоваться от класса Product
    {

        public double price;

        public Product(double price)
        {
            this.price = price;
        }

        public Product()
        {
           
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

    }
}
