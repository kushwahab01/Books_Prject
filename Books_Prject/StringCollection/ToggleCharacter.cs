using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject.StringCollection
{
    class ToggleCharacter
    {
        static void ToggleChar(char[] str)
        {
            for(int i=0; i<str.Length; i++)
            {
                if(str[i]>='A' && str[i]<='Z' )
                {
                    str[i] = (char)(str[i] + 'a' - 'A');
                }
                else if(str[i]>='a' && str[i]<='z')
                {
                    str[i] = (char)(str[i] + 'A' - 'a');
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str1 = Console.ReadLine();
            char[] str = str1.ToCharArray();
            Console.WriteLine(str);
            ToggleChar(str);
            Console.WriteLine(string.Join(" ",str));
        }
    }
}
