using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class SumOfTwoInt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value n1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value n2");
            int n2 = int.Parse(Console.ReadLine());

            int n3 = n1 + n2;
            Console.WriteLine("The value of two integer is: "+n3);
        }
    }
}
