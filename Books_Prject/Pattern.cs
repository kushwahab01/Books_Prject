using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class Pattern
    {
        static void Main(string[] args)
        {
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine(".............................");

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<5; j++)
                {
                    if(i==0 || j == 0 || i == 3 || j==5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
