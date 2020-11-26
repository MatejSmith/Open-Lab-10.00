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
        public string newLine = Environment.NewLine;

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
                if (value > 0)
                {
                    pages = value;
                }
                else
                {
                    pages = 1;
                }
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
                if (value < 2021 && value > 1450)
                {
                    releaseDate = value;
                }
                else
                {
                    releaseDate = -1;
                }

            }
        }
        public override string ToString()
        {
            return "Nazov: " + Title + newLine + "Pocet stran: " + Pages + newLine + "Zaner: " + Category + newLine + "Autor: " + Author + newLine + "Datum vydania: " + ReleaseDate;
        }

        
    }
}