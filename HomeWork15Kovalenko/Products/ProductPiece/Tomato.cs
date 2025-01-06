using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork_15Kovalenko/*.Products.ProductPiece.ProductPiece*/
{
    public class Tomato : ProductPiece
    {
        public Tomato(decimal _basePrice)
        {
            base.BasePrice = _basePrice;
            base.NameProduct = "Tomato";
        }


        public override void InfoProduct()
        {
            Console.WriteLine($"Продукт: {NameProduct}  на суму: {BasePrice}");
        }


    }
}
