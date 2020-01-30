using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProductInventory> Product = new List<ProductInventory>();

            var Product1 = new ProductInventory("lettuce", 10.5, 50, "Leafy green");
            Product.Add(Product1);
            var Product2 = new ProductInventory("cabbage", 20, 100, "Cruciferous");
            Product.Add(Product2);
            var Product3 = new ProductInventory("pumpkin", 30, 30, "Marrow");
            Product.Add(Product3);
            var Product4 = new ProductInventory("cauliflower", 10, 25, "Cruciferous");
            Product.Add(Product4);
            var Product5 = new ProductInventory("zucchini", 20.5, 50, "Marrow");
            Product.Add(Product5);
            var Product6 = new ProductInventory("yam", 30, 50, "Root");
            Product.Add(Product6);
            var Product7 = new ProductInventory("spinach", 10, 100, "Leafy green");
            Product.Add(Product7);
            var Product8 = new ProductInventory("broccoli", 20.2, 75, "Cruciferous");
            Product.Add(Product8);
            var Product9 = new ProductInventory("garlic", 30, 20, "Leafy green");
            Product.Add(Product9);
            var Product10 = new ProductInventory("silverbeet", 10, 50, "Marrow");
            Product.Add(Product10);

            Console.WriteLine("Total products in the list = " + Product.Count);

            var Product11 = new ProductInventory("Potato", 10, 50, "Root");
            Product.Add(Product11);

            Console.WriteLine("Complete list of the products:-");
            Console.WriteLine("NAME   PRICE   QUANTITY   TYPE");

            foreach (var n in Product)
            {
                Console.WriteLine(n.Name + "   " + n.Price + "   " + n.Quantity + "   " + n.Type);
            }

            Console.WriteLine("Total products after updation =" + Product.Count);

            Console.WriteLine("List of leafy green products:-");
            Console.WriteLine("NAME          PRICE    QUANTITY   TYPE");
            foreach (var n in Product)
            {
                if (n.Type == "Leafy green")
                {
                    Console.WriteLine(n.Name + "   " + n.Price + "   " + n.Quantity + "   " + n.Type);
                }
            }


            Product.Remove(Product9);
            Console.WriteLine("Total products after removal of Galic = " + Product.Count);

            foreach (var n in Product)
            {
                if (n.Name == "cabbage")
                {
                    n.Quantity += 50;
                    Console.WriteLine("Updated quantity of Cabbage:" + n.Quantity);
                }
            }


            Console.WriteLine("Customer's Bill Reciept for 1 kg of Lettuce, 2 kg of Zucchini and 1 kg of Broccoli");
            double TotalBill = 0;
            foreach (var n in Product)
            {

                if (n.Name == "lettuce")
                {
                    Console.WriteLine("Lettuce rate = " + n.Price + " per Kg");
                    TotalBill += 1 * n.Price;
                }


                if (n.Name == "zucchini")
                {
                    Console.WriteLine("Zucchini rate = " + n.Price + " per Kg");
                    TotalBill += 2 * n.Price;


                }
                if (n.Name == "broccoli")
                {
                    Console.WriteLine("Broccoli rate = " + n.Price + " per Kg");
                    TotalBill += 1 * n.Price;

                }
            }

            Console.WriteLine("Nett Payable Amount = Rs." + TotalBill);


            Console.ReadKey();
        }
    }
}
