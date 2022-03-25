using System;
namespace HW_004_09
{
    public class Temple_of_Artemis
    {
        private string name = "Храм Артемиды";
        private string creators = "Херсифрон разработал проект Храма и начал его строить. Пеоний и Деметрий закончили строение";
        private string date_of_construction = "560 г. до н. э.";
        private string place_of_construction = "Турция, Эфес";
        private string date_of_destruction = "356 г. до н. э.";

        public Temple_of_Artemis()
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