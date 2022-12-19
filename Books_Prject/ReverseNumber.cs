using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            int n, rev = 0, lastdigit;
            Console.WriteLine("Ener the element");
            n = int.Parse(Console.ReadLine());

            while(n!=0)
            {
                lastdigit = n % 10;
                rev = rev * 10 + lastdigit;
                n = n / 10;
            }
            Console.WriteLine(rev);
        }

    }
}
