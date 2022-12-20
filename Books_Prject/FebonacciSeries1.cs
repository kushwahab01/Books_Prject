using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class FebonacciSeries1
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1, c;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);

            do
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            } while (c < n - a);
        }
    }
}
