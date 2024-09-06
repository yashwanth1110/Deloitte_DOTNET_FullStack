using System;
using System.Collections.Generic;
using System.Data;
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

            string cmdText = "SELECT * FROM Products";

            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, connStr);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0},{1},{2},{3},{4}", row["productId"].ToString(), row["name"].ToString(), row["price"].ToString(), row["quantity"].ToString(), row["category"].ToString());
            }

            Console.ReadLine();

        }
    }
}