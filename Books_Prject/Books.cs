using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class Books
    {
        private int id;
        private string name;
        private string author;
        private double price;
        public Books(int id, string name, string author, double price)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.price = price;
        }
        public override string ToString()
        {
            return $"Book id :{id} , book name : {name} , book author : {author} , Book price : {price}";
        }
        static void Main(string[] args)
        {
            Books b = new Books(101, "Wing", "Harry", 210);
            Console.WriteLine(b);
        }
    
}
}
