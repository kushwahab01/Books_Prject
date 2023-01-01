using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class Practice
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3, value = 1;
            while(b!=0)
            {
                value = value * a;
                --b;
            }
            Console.WriteLine(value);
        }
    }
}
