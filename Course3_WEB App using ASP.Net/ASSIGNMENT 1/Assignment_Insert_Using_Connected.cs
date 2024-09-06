﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=USHYDYYASHWAN1; Database=Employee;Integrated Security=true";

            // using block will dispose the object after execution of block of statements 
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                System.Console.WriteLine("Enter Product ID : ");
                int pid = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter Name : ");
                string pname = Console.ReadLine();

                System.Console.WriteLine("Enter price : ");
                int pprice = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter quantity : ");
                int pquantity = int.Parse( Console.ReadLine());

                System.Console.WriteLine("Enter category : ");
                string pcat = (Console.ReadLine());

                string cmdText = string.Format("INSERT INTO Products  VALUES ({0}, '{1}', {2}, {3}, '{4}')",pid, pname, pprice, pquantity, pcat);
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                int n=(int)cmd.ExecuteNonQuery();
                Console.WriteLine("Table Updated");
                conn.Close();
            };


            Console.ReadLine();
        }
    }
}