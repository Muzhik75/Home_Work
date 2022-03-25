using System;

namespace HW_003_06
{
    public class Client
    {
        public int idClient;
        public string nameClient;
        public string addressClient;
        public string telNumber;
        public int quantityOrders;
        public double summTotal;
        public string clientType;


        public Client()
        {
            Console.Write("Введите ID клиента: ");
            this.idClient = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите ФИО клиента: ");
            this.nameClient = Console.ReadLine();
            
            Console.Write("Введите адрес клиента: ");
            this.addressClient = Console.ReadLine();
            
            Console.Write("Введите номер телефона клиента: ");
            this.telNumber = Console.ReadLine();
            
            Console.Write("Введите количество заказов клиента: ");
            this.quantityOrders = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите сумму заказов клиента: ");
            this.summTotal = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите тип покупателя:");
            Console.Write("1 - Единичный; ");
            Console.Write("2 - Редкий; ");
            Console.Write("3 - Постоянный; ");
            Console.Write("4 - VIP; ");
            int type = Convert.ToInt32(Console.ReadLine());
            this.clientType = Enum.GetName(typeof(ClientType), type);
        }
        
        public void PrintClientInfo()
        {
            Console.WriteLine("ID клиента - " + idClient);
            Console.WriteLine("Имя клиента - " + nameClient);
            Console.WriteLine("Имя клиента - " + addressClient);
            Console.WriteLine("Имя клиента - " + telNumber);
            Console.WriteLine("Имя клиента - " + quantityOrders);
            Console.WriteLine("Имя клиента - " + summTotal);
            Console.WriteLine("Имя клиента - " + clientType);
        }
        
        

        }
}