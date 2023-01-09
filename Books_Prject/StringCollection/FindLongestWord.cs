using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject.StringCollection
{
    //12.	Write a C# program to find highest frequency character in a string.

    class FindLongestWord
    {
        public static void LongestWord(string str)
        {
            string[] s = str.Split();
            int max = 0;
            for(int i=0; i<s.Length; i++)
            {
                if(s[i].Length>max)
                {
                    max = s[i].Length;
                }
            }
            for(int i=0; i<s.Length; i++)
            {
                if(s[i].Length==max)
                {
                    Console.WriteLine(s[i]);
                }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            FindLongestWord.LongestWord(str);
        }
    }
}
