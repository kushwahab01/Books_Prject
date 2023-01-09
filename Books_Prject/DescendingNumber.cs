using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class DescendingNumber
    {   
        static void ToogleChar(char[] a)
        {
            for(int i=0; i<a.Length; i++)
            {
                if(a[i]>='A' && a[i]<='Z')
                {
                    a[i] = (char)(a[i] + 'a' - 'A');
                }
                else if(a[i]>='a' && a[i]<='z')
                {
                    a[i] = (char)(a[i] + 'A' - 'a');
                }
            }
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] a = str.ToCharArray();
            Console.WriteLine(a);
            ToogleChar(a);
            Console.WriteLine(string.Join(" ",a));
        }

       
    }
}
