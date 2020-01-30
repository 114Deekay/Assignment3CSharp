using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class ProductInventory
    {


        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public string Type { get; set; }



        public ProductInventory(string name, double price, int quantity, string type)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Type = type;
        }

    }
}
