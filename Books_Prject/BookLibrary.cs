using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public enum TypeOfBooks { Adventure, Horror, Crime, Historical}

    class BookLibrary
    {
        public int Bid { get; set; }
        
        public string Author { get; set; }
        public double Price { get; set; }
       
        public TypeOfBooks TypeOfBooks;
        public List<BooksLib> booksLibs = new List<BooksLib>();
    }
    public class BooksLib
    {
        public string Bname { get; set; }
    }
    public class BookDetails
    {
        static void Main(string[] args)
        {
            List<BookLibrary> bk = new List<BookLibrary>()
            {
                new BookLibrary
                {
                    Bid=1,
                    Author="Harry",
                    TypeOfBooks=TypeOfBooks.Adventure,
                    Price=100,
                    booksLibs=
                    {
                        new BooksLib{Bname="Traser Island"},
                        new BooksLib{Bname="The call of the Wild"},
                        new BooksLib{Bname="Journy to the west"},
                        new BooksLib{Bname="Around The world in Eighteen"},
                    }
                },
                new BookLibrary
                {
                    Bid=2,
                    Author="Harry1",
                    TypeOfBooks=TypeOfBooks.Crime,
                    Price=150,
                    booksLibs=
                    {
                        new BooksLib{Bname="Killing Floar"},
                        new BooksLib{Bname="Death on the nile"},
                        new BooksLib{Bname="The Dry"},
                        new BooksLib{Bname="Dark Places"},
                    }
                },
                new BookLibrary
                {
                    Bid=3,
                    Author="Harry2",
                    TypeOfBooks=TypeOfBooks.Historical,
                    Price=120,
                    booksLibs=
                    {
                        new BooksLib{Bname="War and Peace"},
                        new BooksLib{Bname="The guns of August"},
                        new BooksLib{Bname="The pillers of the Earth"},
                        new BooksLib{Bname="1 King"},
                    }
                },
                new BookLibrary
                {
                    Bid=4,
                    Author="harry3",
                    TypeOfBooks=TypeOfBooks.Horror,
                    Price=250,
                    booksLibs=
                    {
                        new BooksLib{Bname="Draculas"},
                        new BooksLib{Bname="The Shining"},
                        new BooksLib{Bname="House of leaves"},
                        new BooksLib{Bname="Bird Box"},
                    }
                }
            };
            foreach (BookLibrary item in bk)
            {
                Console.WriteLine($"Book Id is : {item.Bid}, Name Of Author is :{item.Author}, Price of Book is: {item.Price},");
                foreach (BooksLib b in item.booksLibs)
                {
                   if (b.Bname.StartsWith("T"))
                    {
                        Console.WriteLine("\t"+b.Bname);
                    }
                   
                    
                }
            }
        }
    }
}
