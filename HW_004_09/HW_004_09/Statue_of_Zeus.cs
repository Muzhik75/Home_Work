using System;
namespace HW_004_09
{
    public class Statue_of_Zeus
    {
        private string name = "Статуя Зевса";
        private string creators = "Фидий";
        private string date_of_construction = "435 г. до н. э.";
        private string place_of_construction = "Греция, Олимпия";
        private string date_of_destruction = "425 г.";

        public Statue_of_Zeus()
        {
            
        }

        public void PrintInfo()
        {
            Console.WriteLine("_____________________");
            Console.WriteLine($"{this.name}");
            Console.WriteLine($"Создатели: {this.creators}");
            Console.WriteLine($"Дата постройки - {this.date_of_construction}");
            Console.WriteLine($"Место постройки - {this.place_of_construction}");
            Console.WriteLine($"Дата разрушения - {this.date_of_destruction}");
            Console.WriteLine("_____________________");
        }
    }
}