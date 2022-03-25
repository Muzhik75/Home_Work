using System;

namespace HW_003_07
{
    enum PayType
    {
        Cash = 1,
        Card,
        Check,
        Bank
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Request request = new Request();
            request.PrintInfoRequest();
            
            
            Console.WriteLine("Конец программы.");
        }
    }
}