using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class order
    {
        public baskets[] basket1 = new baskets[10];
        public void Make_an_order()
        {
            baskets basket = new baskets();
            product[] products = new product[10];
            product product1 = new product();
            product1.Make_a_product_list(products);
            int amount = new Random().Next(1, 6);
            for(int i = 0; i < amount; i++)
            {
                int number = new Random().Next(0, 10);
                basket.products[i] = products[number];
            }
            this.basket1.Prepend(basket);
            this.Callback(basket);
        }

        public void Callback(baskets basket1)
        {
            Console.WriteLine("Your order is ready\nYou ordered:");
            basket1.Write_basket();
        }
    }
}
