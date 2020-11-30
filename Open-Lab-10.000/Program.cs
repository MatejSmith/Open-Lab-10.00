using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            Book LOTR2 = new Book();
            Book LOTR3 = new Book("Detvan", 200);
            Book HOBIT = new Book("The Hobbit", 310, "Fantasy Roman", "J. R. R. Tolkien", 1937);

            LOTR.Title = "Popol všetkých zarovná";
            LOTR.Pages = 240;
            LOTR.Category = "Detektívny román";
            LOTR.Author = "Dominik Dán";
            LOTR.ReleaseDate = 2005;

            Console.WriteLine("Nazov: " + LOTR.Title);
            Console.WriteLine("Pocet stran: " + LOTR.Pages);
            Console.WriteLine("Zaner: " + LOTR.Category);
            Console.WriteLine("Autor: " + LOTR.Author);
            Console.WriteLine("Datum vydania: " + LOTR.ReleaseDate + "\n");

            Console.WriteLine(LOTR2.ToString() + "\n");
            Console.WriteLine(LOTR3.ToString() + "\n");
            Console.WriteLine(HOBIT.ToString() + "\n");

            Console.ReadKey();
        }
    }
}