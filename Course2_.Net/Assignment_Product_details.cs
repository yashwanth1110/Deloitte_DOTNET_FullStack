using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            int price;
            int quantity;
            double total;
            double discount;
            double final;
            Console.WriteLine("Product Id:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Product Name:");
            name = Console.ReadLine();
            Console.WriteLine("Unit Price:");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantity:");
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Product Id:" + id);
            Console.WriteLine("Product Name:" + name);
            Console.WriteLine("Unit Job:" + price);
            Console.WriteLine("Quantity:" + quantity);
            total  = price * quantity;
            Console.WriteLine("Total Amount:" + total);
            if (quantity > 10)
            {
                discount = total * 0.1;
            }
            else if (quantity > 20)
            {
                discount = total * 0.2;
            }
            else if (quantity > 50)
            {
                discount = total * 0.3;
            }
            else
            {
                discount = total;
            }
            Console.WriteLine("Discount Amount:" + discount);
            final = total - discount;
            Console.WriteLine("Final Amount:" + final);
            Console.ReadLine();


        }
    }
}

