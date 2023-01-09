using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class SampleExp
    {
        static void Main(string[] args)
        {
            string str = "hello";
            Console.WriteLine(str.GetHashCode());
            str = str + "Good Mornig";

            Console.WriteLine(str.GetHashCode());
            

           /* string str1 = "Good Morning";
            Console.WriteLine(str.GetHashCode());
            str.Concat(str1);
            Console.WriteLine(str.GetHashCode());*/
            
        }
    }
}
