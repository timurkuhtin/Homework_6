using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class product
    {
        public string name;
        public int price;
        public string comment;

        public void MakeAProductList(product[] products)
        {
            for (int i = 0; i < 6; i++)
            {
                products[i] = new product();
                products[i].name = $"number {i+1}";
                products[i].price = new Random().Next(100, 1000);
                products[i].comment = $"product number {i+1}";
            }
        }
    }
}
