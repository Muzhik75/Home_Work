using System;
using System.Runtime.CompilerServices;

namespace HW_003_05
{
    public class Article
    {
        public int idProduct;
        public string titleProduct;
        public double priceProduct;
        public string articleType;

        public Article()
        {
            Console.Write("Введите ID товара: ");
            this.idProduct = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите название товара: ");
            this.titleProduct = Console.ReadLine();
            
            Console.Write("Введите цену товара: ");
            this.priceProduct = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите тип товара:");
            Console.Write("1 - Хозтовары; ");
            Console.Write("2 - Продукты; ");
            Console.Write("3 - Автозапчасти; ");
            Console.Write("4 - Электроника; ");
            int type = Convert.ToInt32(Console.ReadLine());
            this.articleType = Enum.GetName(typeof(ArticleType), type);
        }
        
        
        public void PrintProductInfo()
        {
            Console.WriteLine($"{this.idProduct} \t {this.titleProduct} \t {this.priceProduct} \t {this.articleType}");
        }
        
    }
}
