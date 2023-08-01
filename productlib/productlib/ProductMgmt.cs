using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productlib
{
    public class ProductMgmt
    {
        static List<Product> products;
        public ProductMgmt()
        {
            products = new List<Product>()
            {
                new Product {ID=1, Name="Soap",Price=95.50,MFDate=new DateTime(day:12,month:11,year:2024)},
                new Product {ID=1, Name="Garlic",Price=180.00,MFDate=new DateTime(day:03,month:08,year:2023)},
                new Product {ID=1, Name="Face wash",Price=130.75,MFDate=new DateTime(day:26,month:12,year:2025)}
            };
        }
        public void PrintList()
        {
            foreach (Product product in products)
            {
                Console.WriteLine("ID:" + product.ID);
                Console.WriteLine("Name:" + product.Name);
                Console.WriteLine("MFDate:" + product.MFDate);
                Console.WriteLine("Price:" + product.Price);
            }
        }
        public void AddProduct(Product pro)
        {
            products.Add(pro);
            Console.WriteLine("List after adding product");
            this.PrintList();
        }


    }
    
}
