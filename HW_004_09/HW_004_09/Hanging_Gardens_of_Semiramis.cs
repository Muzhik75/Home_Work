using System;
namespace HW_004_09
{
    public class Hanging_Gardens_of_Semiramis
    {
        private string name = "Висячие сады Семирамиды";
        private string creators = "были возведены по приказу Навуходоносора II";
        private string date_of_construction = "605 г. до н. э.";
        private string place_of_construction = "Ирак, Вавилон";
        private string date_of_destruction = "в 126 году до н. э. разрушены персами.";

        public Hanging_Gardens_of_Semiramis()
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