using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class PalindromOrNot
    {
        static void Main(string[] args)
        {
            string rev = " ";
            string str = Console.ReadLine();
            char[] ch = str.ToArray();
            Array.Reverse(ch);
            rev = new string(ch);

            bool b = str.Equals(rev);
            if(b==true)
            {
                Console.WriteLine("String is palindrom");
            }
            else
            {
                Console.WriteLine("String is not a palindrom");
            }

        }
    }
}
