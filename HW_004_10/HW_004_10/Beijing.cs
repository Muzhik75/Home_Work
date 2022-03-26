using System;

namespace China

{
    public class Beijing
    {
        public int population;

        public Beijing()
        {
            Console.Write("Укажите население Пекина: ");
            population = Convert.ToInt32(Console.ReadLine());
        }
    }
}