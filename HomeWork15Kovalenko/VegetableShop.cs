using HomeWork_15Kovalenko/*.Products*/;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork_15Kovalenko

{
    public  class VegetableShop
    {
     

        public  List<Product> AddProducts(List<Product> listProducts)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);
            decimal totalPrice = 0;
            


            while (true)
            {   
                Console.Clear();
                Console.WriteLine($"Додавання товару в корзину!\n");
                Console.WriteLine("1 - Tomato.\n2 - Carrot.\n3 - Potato.\n4 - Cucumber.\n");
                Console.Write($"Виберіть товар:");



                bool outBlendNameProduct = int.TryParse(Console.ReadLine(), out int indexProduct);

                if (outBlendNameProduct && indexProduct > 0 && indexProduct <= 4)
                {
                    switch ((NameProduct)indexProduct)
                    {
                        case NameProduct.tomato:
                            {
                                Console.Write("Товара на сумму: - ");
                                if (decimal.TryParse(Console.ReadLine(), out decimal quantity))
                                {

                                    listProducts[0].BasePrice -= quantity;
                                    totalPrice += quantity;
                                }
                                else { PrintBlend(); }
                            }
                            break;
                        case NameProduct.carrot:
                            {
                                Console.Write("Товара на сумму: - ");
                                if (decimal.TryParse(Console.ReadLine(), out decimal quantity))
                                {

                                    listProducts[1].BasePrice -= quantity;
                                    totalPrice += quantity;
                                }
                                else { PrintBlend(); }
                            }
                            break;
                        case NameProduct.potato:
                            {
                                Console.Write("Товара в кількості: - ");
                                if (decimal.TryParse(Console.ReadLine(), out decimal quantity))
                                {

                                    listProducts[2].Count -= quantity;
                                    totalPrice += quantity * listProducts[2].BasePrice;
                                }
                                else { PrintBlend(); }

                            }
                            break;
                        case NameProduct.cucumber:
                            {
                                Console.Write("Товара в кількості: - ");
                                if (decimal.TryParse(Console.ReadLine(), out decimal quantity))
                                {

                                    listProducts[3].Count -= quantity;
                                    totalPrice += quantity * listProducts[3].BasePrice;
                                }
                                else { PrintBlend(); }
                            }
                            break;
                    }
                }
                else { PrintBlend(); }

                Console.WriteLine($"Товарів в корзині на суму {totalPrice}");
                Console.WriteLine();

              
                Console.Write("Додати ще товару: 1 - Yes / 2 - No ");

                if(int.TryParse(Console.ReadLine(), out int exit))
                { 
                    if (exit == 2)

                    { break; }

                    else if (exit == 1)

                    { continue; }
                }else { PrintBlend(); }


        }
        
            return listProducts;
        }



        //public void PrintProductsInfo(List<Product> products)
        //{
        //    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.InputEncoding = Encoding.GetEncoding(1251);

        //    decimal totalPrice = 0;
        //    foreach (var item in products)
        //    {

        //        totalPrice += item.BasePrice;
        //        Console.WriteLine($"");
        //    }
        //    Console.WriteLine($"\nВсього товару на суму: { totalPrice}");

      
        // }
        public void PrintBlend()
        {
            Console.WriteLine("Введені не вірні дані");
        }


    }

    
    enum NameProduct
    {
        tomato = 1,
        carrot,
        potato,
        cucumber
    }

}
