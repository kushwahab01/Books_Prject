using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    
    class NumberIsIncreasingOrDec
    {
        
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool isIncreasing = true;
            bool isDecreasing = true;

            int lastDigit = n % 10;

            n = n / 10;
            while(n>0)
            {
                int currentDigit = n % 10;
                if(currentDigit>lastDigit)
                {
                    isIncreasing = false;
                }
                else if(currentDigit<lastDigit)
                {
                    isDecreasing = false;
                }
                lastDigit = currentDigit;
                n = n / 10;
            }
            if(isIncreasing)
            {
                Console.WriteLine("Increasing");
            }
            else if(isDecreasing)
            {
                Console.WriteLine("Decreasing");
            }
            else
            {
                Console.WriteLine("Bouncy");
            }
        }
    }
}
