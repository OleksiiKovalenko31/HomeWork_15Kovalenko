using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15Kovalenko/*.Products*/
{
    public class Product
    {
        public virtual decimal BasePrice { get; set; }
        public virtual string? NameProduct { get; set; }
        public virtual decimal Count { get; set; }

        public virtual void InfoProduct()
        {
            Console.WriteLine();
        }


    }
}
