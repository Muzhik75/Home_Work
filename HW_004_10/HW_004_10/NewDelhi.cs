using System;

namespace India
{
    public class NewDelhi
    {
        public int population;

        public NewDelhi()
        {
            Console.Write("Укажите население Нью Дели: ");
            population = Convert.ToInt32(Console.ReadLine());
        }
    }
}