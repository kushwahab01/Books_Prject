using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class FindThirdAngle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first angle");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second angle");
            double b = Convert.ToDouble(Console.ReadLine());

            double angle = 180 - (a + b);

            Console.WriteLine("Third angle is :" + angle);

        }
    }
}
