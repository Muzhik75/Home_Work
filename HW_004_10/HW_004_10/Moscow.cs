using System;

namespace Russia
{
    public class Moscow
    {
        public int population;

        public Moscow()
        {
              Console.Write("Укажите население Москвы: ");
              population = Convert.ToInt32(Console.ReadLine());

        }
    }
    
}