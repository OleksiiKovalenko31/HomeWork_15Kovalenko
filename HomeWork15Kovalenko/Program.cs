using HomeWork_15Kovalenko/*.Products;*/;
using System.Text;


namespace HomeWork_15Kovalenko
{
    public class Program
    {

        static void Main()
        {

            List<Product> products = new()
            {
                new Tomato (100),
                new Carrot(100),
                new Potato(5, 50),
                new Cucumber(2, 50)
            };

            VegetableShop shop = new();
            products = shop.AddProducts(products);

            Console.Clear();
            PrintProductsInfo(products);


        }


        public static void PrintProductsInfo(List<Product> products)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);

            decimal totalPrace = 0;
            foreach (var item in products)
            {

                item.InfoProduct();
                totalPrace += item.BasePrice;

            }
            Console.WriteLine($"\nВ магазині\nВсього товару на суму: {totalPrace}");



        }

    }
   
}
//var products = new List<Product>()
//{
//    new Carrot(15),
//    new Potato(20, 4),
//    new Cucumber(14, 2)
//};


//VegetableShop shop = new VegetableShop();
//shop.AddProducts(products);


//shop.PrintProductsInfo();


// Output:
// Product: Carrot, Price: 15
// Product: Potato, Price: 20, Count: 4, Total price: 80
// Product: Cucumber, Price: 14, Count: 2, Total price: 28
// Total products price: 123