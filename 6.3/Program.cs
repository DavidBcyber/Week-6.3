using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class Book // type of class
    {
        // public strings and ints
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }

        public Book(string Title, string Author, string Genre, int Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.Genre = Genre;
            this.Price = Price;
        }
        //Display Info
        public virtual void DisplayInfo()
        {
            Console.WriteLine($" {Title} -- {Author} -- {Genre} -- {Price} ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book Info
            Book book1 = new Book("The great one", "Jacob N", "Fantasty", 25);
            book1.DisplayInfo();


            Book book2 = new Book("The one that escape", "Maximize N", "Fiction", 25);
            book2.DisplayInfo();
        }

    }
}
