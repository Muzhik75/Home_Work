using System;
namespace HW_004_09
{
    public class Lighthouse_of_Alexandria
    {
        private string name = "Александрийский маяк";
        private string creators = "греки, династия Птолемеев";
        private string date_of_construction = "303 г. до н. э.";
        private string place_of_construction = "Египет, Александрия";
        private string date_of_destruction = "XIV в.";

        public Lighthouse_of_Alexandria()
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