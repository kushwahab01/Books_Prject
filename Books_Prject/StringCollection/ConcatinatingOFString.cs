using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ConcatinatingOFString
    {
        static void Main(string[] args)
        {
            string str = "good";
            string str1 = "Morning";
            string res = string.Concat(str, str1);
            
            Console.WriteLine(res);
        }

        
    }
}
