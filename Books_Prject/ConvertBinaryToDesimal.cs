using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ConvertBinaryToDesimal
    {
        static void Main(string[] args)
        {
      
            int num = int.Parse(Console.ReadLine());
            int bvalue = 1;
            int rem;
            int devalue = 0;
            while (num > 0)
            {
                rem = num % 10;
                devalue = devalue + rem * bvalue;
                num = num / 10;
                bvalue = bvalue * 2;
            }
            Console.WriteLine(devalue);
        }
    }
}
