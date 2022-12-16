using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            int n, sum = 0, temp;
            Console.WriteLine("Enter the Number");
            n = int.Parse(Console.ReadLine());

            temp = n;
            while(n>0)
            {
                int r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;

            }
            if(temp==sum)
            {
                Console.WriteLine("Number is armstrong");
            }
            else
            {
                Console.WriteLine("Not A armstrong number");
            }
        }
    }
}
