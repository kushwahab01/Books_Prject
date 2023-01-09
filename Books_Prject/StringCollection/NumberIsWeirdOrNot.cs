using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject.StringCollection
{
    class NumberIsWeirdOrNot
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n%2==0)
            {
                if((n>=2 && n<=5) || (n>20))
                {
                    Console.WriteLine("Not weird");
                }
                else if(n>=6 && n<=20)

                {
                    Console.WriteLine("Weird");
                }
            }
            else
            {
                Console.WriteLine("Weird");
            }
        }
    }
}
