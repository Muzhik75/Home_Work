// Задача 9.
using System;

namespace HW_004_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid_of_Cheops pyramidOfCheops = new Pyramid_of_Cheops();
            pyramidOfCheops.PrintInfo();

            Hanging_Gardens_of_Semiramis hangingGardensOfSemiramis = new Hanging_Gardens_of_Semiramis();
            hangingGardensOfSemiramis.PrintInfo();

            Statue_of_Zeus statueOfZeus = new Statue_of_Zeus();
            statueOfZeus.PrintInfo();

            Temple_of_Artemis templeOfArtemis = new Temple_of_Artemis();
            templeOfArtemis.PrintInfo();

            Mausoleum_of_Halicarnassus mausoleumOfHalicarnassus = new Mausoleum_of_Halicarnassus();
            mausoleumOfHalicarnassus.PrintInfo();

            Colossus_of_Rhodes colossusOfRhodes = new Colossus_of_Rhodes();
            colossusOfRhodes.PrintInfo();

            Lighthouse_of_Alexandria lighthouseOfAlexandria = new Lighthouse_of_Alexandria();
            lighthouseOfAlexandria.PrintInfo();
                
            Console.WriteLine("Конец программы.");
        }
    }
}