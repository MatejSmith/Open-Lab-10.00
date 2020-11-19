using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book("Harry Potter");
            Console.WriteLine(LOTR.title);
            Console.ReadKey();
        }
    }
}