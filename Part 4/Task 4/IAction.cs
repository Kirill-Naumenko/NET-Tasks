using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    interface IAction //ну это уже просто так, можно применять не к корзине, а к пакету например, если мы не в интернет магазине, а в реальном :)
    {

        bool add(Product product);
        bool remove(Product product);

    }
}
