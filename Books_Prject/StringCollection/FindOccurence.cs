using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject.StringCollection
{
    class FindOccurence
    {
        public int Occcurence(string str, string str1)
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
            Console.WriteLine("Enter the string 1");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the string 2");
            string str1 = Console.ReadLine();
        }
    }
}
