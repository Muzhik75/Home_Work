using System;
namespace HW_004_09
{
    public class Colossus_of_Rhodes
    {
        private string name = "Колосс Родосский";
        private string creators = "Харес";
        private string date_of_construction = "между 292 и 280 гг. до н. э.";
        private string place_of_construction = "Греция, Родос";
        private string date_of_destruction = "224 (или 226) г. до н. э. бронзовый корпус был демонтирован в 654 г.";

        public Colossus_of_Rhodes()
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