using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();

            LOTR.Title = "Popol všetkých zarovná";
            LOTR.Pages = 401;
            LOTR.Category = "Detektívny román";
            LOTR.Author = "Dominik Dán";
            LOTR.ReleaseDate = 2005;

            LOTR.VypisUdaje();
            Console.ReadKey();
        }
    }
}