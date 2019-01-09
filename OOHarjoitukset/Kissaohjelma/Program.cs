using System;

namespace Kissaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tämä on kissaohjelma");
           

            Cat myFirstCat = new Cat("Pilli", 1);
            myFirstCat.IncreaseWeight(1);
            myFirstCat.PrintWeight();
            Console.WriteLine("--------------------------------------------------------------\n");

           

            Cat mySecondCat = new Cat("Pulla", 3);
            mySecondCat.IncreaseWeight(2);
            mySecondCat.PrintWeight();
            Console.WriteLine("--------------------------------------------------------------\n");





            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
        }
    }
}
