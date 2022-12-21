
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class PowerClass
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the value of a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = int.Parse(Console.ReadLine());
            long value = 1;
            while(b!=0)
            {
                value = value * a;
                --b;
            }
            Console.WriteLine(value);
        }
    }
}
