using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15Kovalenko/*.Products.ProductByWeight*/
{
    public class Potato : ProductByWeight
    {
        public Potato(decimal _basePrice, decimal _count)
        {
            base.BasePrice = _basePrice;
            base.Count = _count;
            base.NameProduct = "Potato";
        }

        //public override decimal BasePrice { get => base.BasePrice * base.Count; set => base.BasePrice = value * base.Count; }
        public override void InfoProduct()
        {
            Console.WriteLine($"Продукт: {NameProduct}, кількість: {base.Count}, ціна: {base.BasePrice}, на суму: {BasePrice * base.Count}");
        }

    }
}
