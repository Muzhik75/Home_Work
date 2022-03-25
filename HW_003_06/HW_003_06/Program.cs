using System;

namespace HW_003_06
{
    
    enum ClientType
        {
        Default = 1,
        Incetive,
        Patron,
        VIP
        }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.PrintClientInfo();
            
            
            
            Console.WriteLine("Конец программы.");
        }
    }
}