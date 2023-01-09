using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class AnagramProgram
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
           char[] ch= str.ToCharArray();

            string str1 = Console.ReadLine();
            char[] ch1 = str.ToCharArray();

            Array.Sort(ch);
            Array.Sort(ch1);

            string str2 = new string(ch);
            string str3 = new string(ch1);

            if (str2==str3)
            {
             Console.WriteLine("string is anagram");
            }
            else
            {
               Console.WriteLine("string is not anagram");
            }
           
        }
    }
}
