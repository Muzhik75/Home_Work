using System;
using China;
using India;
using Russia;


namespace HW_004_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Beijing beijing = new Beijing();
            NewDelhi newDelhi = new NewDelhi();
            Moscow moscow = new Moscow();

            if (moscow.population > newDelhi.population && moscow.population > beijing.population)
            {
                Console.WriteLine($"Самое большое население в Москве {moscow.population} человек.");
            }
            if (newDelhi.population > beijing.population && newDelhi.population > moscow.population)
            {
                Console.WriteLine($"Самое большое население в Нью Дели {newDelhi.population} человек.");
            }

            if (beijing.population > newDelhi.population && beijing.population > moscow.population)
            {
                Console.WriteLine($"Самое большое население в Пекине {beijing.population} человек.");
            }

            Console.WriteLine("Конец программы.");
        }
    }
}