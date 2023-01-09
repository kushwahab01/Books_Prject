using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{

    //4.	Write a C# program to trim leading white space characters in a string.
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
