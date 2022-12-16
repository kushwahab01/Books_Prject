using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class StringClass
    {
        static void Main(string[] args)
        {
            string s1 = "  Hello to Everyone   ";
           

            string str=s1.Trim();
            string s=s1.TrimEnd();
            string s3 = s1.TrimStart();
            
            Console.WriteLine(s);
            Console.WriteLine(str);
            Console.WriteLine(s3);


        }
    }
}
