using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public int ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                releaseDate = value;
            }
        }
        public void VypisUdaje()
        {
            Console.WriteLine("Title: {0}\nPages: {1}\nCategory: {2}\nAuthor: {3}\nRelease date: {4}", Title, Pages, Category, Author, ReleaseDate);
        }

        
    }
}