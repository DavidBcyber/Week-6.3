using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class Book // The class for the books
    {
        // the book details such as title, author, genre, and price
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }

        public Book(string Title, string Author, string Genre, int Price) // identify for each  deatil and obkect of the class
        {
            this.Title = Title;
            this.Author = Author;
            this.Genre = Genre;
            this.Price = Price;
        }
        public virtual void DisplayInfo() // The display infomration for each book
        {
            Console.WriteLine($" {Title} -- {Author} -- {Genre} -- {Price} ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //book 1 information display of fantasy
            Book book1 = new Book("The great one", "Jacob N", "Fantasy", 25);
            book1.DisplayInfo();

            //book 2 information display of fiction
            Book book2 = new Book("The one that escaped", "Maximize N", "Fiction", 25);
            book2.DisplayInfo();
        }

    }
}
