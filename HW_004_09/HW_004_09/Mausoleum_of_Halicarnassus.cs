using System;
namespace HW_004_09
{
    public class Mausoleum_of_Halicarnassus
    {
        private string name = "Галикарнасский мавзолей";
        private string creators = "Пифей";
        private string date_of_construction = "351 г. до н. э.";
        private string place_of_construction = "Турция, Галикарнас";
        private string date_of_destruction = "1494 г.";

        public Mausoleum_of_Halicarnassus()
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