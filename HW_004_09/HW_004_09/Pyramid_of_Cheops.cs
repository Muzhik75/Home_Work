using System;
namespace HW_004_09
{
    public class Pyramid_of_Cheops
    {
        private string name = "Пирамида Хеопса";
        private string creators = "Египтяне";
        private string date_of_construction = "2600 г.до н.э.";
        private string place_of_construction = "Египет, Гиза";
        private string date_of_destruction = "Существует до сих пор.";

        public Pyramid_of_Cheops()
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