using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class order
    {
        public Baskets[] basket1 = new Baskets[10];
        public void MakeAnOrder()
        {
            Baskets basket = new Baskets();
            product[] products = new product[10];
            product product1 = new product();

            product1.MakeAProductList(products);
            int amount = new Random().Next(1, 6);
            for(int i = 0; i < amount; i++)
            {
                int number = new Random().Next(0, 10);
                basket.products[i] = products[number];
            }
            this.basket1.Prepend(basket);
            this.Callback(basket);
        }

        public void Callback(Baskets basket1)
        {
            Console.WriteLine("Your order is ready\nYou ordered:");
            basket1.WriteBasket();
        }
    }
}
