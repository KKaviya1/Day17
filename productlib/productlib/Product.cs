using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productlib
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public DateTime MFDate { get; set; }
    }
   
}
