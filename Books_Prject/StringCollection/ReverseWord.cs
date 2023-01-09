using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ReverseWord
    {
        static void Main(string[] args)
        {
            string s = "This is my country";
            string[] str = s.Split();
            string rev = "";
            for(int i=0; i<str.Length; i++)
            {
                string word = str[i];
                string wordvalue = "";
                for(int j=0; i<word.Length; j++)
                {
                    wordvalue = word[j] + wordvalue;
                }
                rev = rev + wordvalue;
            }
            Console.WriteLine(rev);
        }
    }
}
