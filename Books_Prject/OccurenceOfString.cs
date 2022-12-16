using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class OccurenceOfString
    {
        static int Occurence(string str, string str1)
        {
            string[] a = str.Split(' ');
            int count = 0;
            for(int i=0; i<a.Length; i++)
            {
                if (str1.Equals(a[i]))
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the word");
            string str1 = Console.ReadLine();
            Console.WriteLine(Occurence(str,str1));
        }
    }
}
