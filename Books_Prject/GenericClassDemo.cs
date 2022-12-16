using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public class GenericClassDemo<T>
    {
        private T data;
        public void Add(T data)
        {
            this.data = data;

        }
        public T Print()
        {
            return data;
        }
       
    }
    public class Prog
    {
        static void Main(string[] args)
        {
            GenericClassDemo<int> g = new GenericClassDemo<int>();
            g.Add(10);

            Console.WriteLine(g.Print());

            GenericClassDemo<string> g1 = new GenericClassDemo<string>();
            g1.Add("Hello");

            Console.WriteLine(g1.Print());


        }
    }

    
}
