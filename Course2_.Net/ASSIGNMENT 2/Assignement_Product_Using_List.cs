using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Assignment
{
    class Product
    {
        public int Pid { get; set; }
        public string Name { get; set; }
        public int quantity { get; set; }
        public string category { get; set; }




    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product() { Pid = 201, Name = "Move", quantity = 7, category = "Makeup Accessories" };
            Product p2 = new Product() { Pid = 202, Name = "HP", quantity = 25, category = "Laptops" };
            Product p3 = new Product() { Pid = 203, Name = "Doll", quantity = 14, category = "Soft Toys" };
            Product p4 = new Product() { Pid = 204, Name = "Benz", quantity = 9, category = "Cars" };
            Product p5 = new Product() { Pid = 205, Name = "Kurthi", quantity = 5, category = "Dresses" };

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);
            products.Add(p5);

            foreach (Product p in products)
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadLine();
        }
    }
}