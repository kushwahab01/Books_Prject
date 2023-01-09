using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ToggleChar
    {
        static void ToggleChars(char[] str)
        {
            for(int i=0; i<str.Length; i++)
            {
                if(str[i]>='A'  && str[i]<='Z')
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
            char[] str = "BrIjEsh".ToCharArray();
            Console.WriteLine(str);
            ToggleChars(str);
            Console.WriteLine("string after toggle");
            Console.WriteLine(string.Join(" ",str));

        }

    }
}
