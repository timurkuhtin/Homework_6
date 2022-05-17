using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class Baskets
    {
        public int NumberOfOrder;
        public product[] products = new product[10];

        public void WriteBasket()
        {
            int sum = 0;
            for(int i = 0; i < this.products.Length; i++)
            {
                if (this.products[i] != null)
                {
                    Console.WriteLine($"name:{this.products[i].name} price:{this.products[i].price} comment:{this.products[i].comment}");
                    sum += this.products[i].price;
                }
            }
            Console.WriteLine($"To pay:{sum}");
        }

    }
}
