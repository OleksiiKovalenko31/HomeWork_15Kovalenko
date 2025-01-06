using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15Kovalenko/*.Products.ProductPiece.ProductPiece*/
{
    public class Carrot : ProductPiece
    {
        public Carrot(decimal _basePrice)
        {
            base.BasePrice = _basePrice;
            base.NameProduct = "Carrot";
        }
        //public override decimal Count { get => base.Count; set => base.Count = value; }
        public override void InfoProduct()
        {
            Console.WriteLine($"Продукт: {NameProduct} на суму: {BasePrice}");
        }
    }
}
