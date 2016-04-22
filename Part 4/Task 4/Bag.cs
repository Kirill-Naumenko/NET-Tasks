using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Bag : IAction
    {

       public List<Product> bag; //Корзина у нас имееет коллекцию продуктов, из корзины можно добвлять и удалять продукты

            public Bag()
        {
            bag = new List<Product>();
        }

        public bool add(Product product)
        {
            bag.Add(product);

            if (bag.Contains(product))
            {
                return true;
            }
            return false; 
    
        }

        public bool remove(Product product)
        {
            bag.Remove(product);

            if (bag.Contains(product))
            {
                return false;
            }
            return true;
        }
    }
}
