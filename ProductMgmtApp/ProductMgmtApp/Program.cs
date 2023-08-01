using productlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppProductMgmtApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Opearation \n 1. Show List \n 2. Add product");
            int op = int.Parse(Console.ReadLine());
            ProductMgmt mgmt = new ProductMgmt();
            switch (op)
            {
                case 1:
                    {
                        mgmt.PrintList();
                        break;
                    }
                case 2:
                    {
                        Product obj = new Product();
                        Console.WriteLine("Enter ID");
                        obj.ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Product name");
                        obj.Name = Console.ReadLine();
                        Console.WriteLine("Enter Product Price");
                        obj.Price = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter MfDate");
                        obj.MfDate = DateTime.Parse(Console.ReadLine());
                        mgmt.AddProcut(obj);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Operation ");
                        break;

                    }


            }
            Console.ReadKey();

        }
    }
}