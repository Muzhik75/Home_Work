using System;
using System.Collections.Generic;
namespace HW_003_07
{
    public class Request
    {
        private static int id = id;
        public int codeOhRequest;
        public Client client;
        public Dictionary<string, int> listOfgoods;
        public int Summ = 0;
        public string payType;

        public Request()
        {
            id++;
            this.codeOhRequest = id;
            listOfgoods = new Dictionary<string, int>();
            this.client = new Client();
            
            Console.Write("Введите тип оплаты:");
            Console.Write("1 - Наличные; ");
            Console.Write("2 - Карта; ");
            Console.Write("3 - Чек; ");
            Console.Write("4 - Банковский перевод; ");
            int type = Convert.ToInt32(Console.ReadLine());
            this.payType = Enum.GetName(typeof(PayType), type);
            
            Console.Write("Хотите продолжить y/n?: ");
            string stopContinue = Console.ReadLine();
            
            while (stopContinue == "y")
            {
                Console.Write("Введите название товара: ");
                string name = Console.ReadLine();
                Console.Write("Введите цену товара: ");
                int price = Convert.ToInt32(Console.ReadLine());
                this.listOfgoods.Add(name, price);
                Console.Write("Хотите продолжить y/n?: ");
                stopContinue = Console.ReadLine();
            }

            this.CalculateSumm();

        }

        public void CalculateSumm()
        {
            foreach (var item in listOfgoods)
            {
                this.Summ += item.Value;
            }
        }

        public void PrintInfoRequest()
        {
            Console.WriteLine("ID заказа" + this.codeOhRequest);
            Console.WriteLine("--------Инфо о клиенте--------");
            this.client.PrintClientInfo();
            Console.WriteLine("---------------------------------");
            foreach (var item in listOfgoods)
            {
                Console.WriteLine($"Название товара: {item.Key}");
                Console.WriteLine($"Цена товара: {item.Value}");
                Console.WriteLine($"----------------------------");
            }

            Console.WriteLine($"Сумма - {this.Summ}");
        }
    }
}