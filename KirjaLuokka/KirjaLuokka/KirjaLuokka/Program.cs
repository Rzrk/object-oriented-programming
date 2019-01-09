using System;

namespace KirjaLuokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Kirjat:");

            Book myBook = new Book();
            string text = myBook.PrintInfo();


            Book newBook = new Book("aapinen",
                                    "Mikael Agricola",
                                    "0001",
                                    22.50);

            Console.WriteLine ("\n**************" + newBook.PrintInfo());

            Book newBook2 = new Book("Peppi Pitkätossu", "Astrid Lindgren", "0002", 18.95);
            Console.WriteLine(newBook2.PrintInfo());

            /* tapa 1
            newBook.CompareBook(newBook2);
            Console.WriteLine(newBook.CompareBook(newBook2));*/

            //tapa2

            string compareText = newBook.CompareBook(newBook2);
            {
                Console.WriteLine(compareText);
            }





        }
    }
}
