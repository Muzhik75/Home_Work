using System;
using System.Runtime.CompilerServices;

namespace HW_003_05
{
    enum ArticleType
    {
        household_Goods = 1,
        food_Products,
        auto_Parts,
        electronic
    }
    class Program
    {
        static void Main(string[] args)
        {
            Article art = new Article();
            art.PrintProductInfo();
            
            Console.WriteLine("Конец программы.");
        }
    }
}