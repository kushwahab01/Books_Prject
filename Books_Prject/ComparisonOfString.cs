using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ComparisonOfString
    {
        static void Main(string[] args)
        {
            string str = "test";
            string str1 = "Zebra";

            int res = string.Compare(str, str1);
            if(res<0)
            {
                Console.WriteLine("string1 is less than string 2");
            }
            else if(res>0)
            {
                Console.WriteLine("string 1 is greater than 2");
            }
            else
            {
                Console.WriteLine("both are equal");
            }
            Console.WriteLine(res);
        }
    }
}
