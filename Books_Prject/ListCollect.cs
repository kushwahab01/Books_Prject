using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ListCollect
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            char[] ar = data.ToCharArray();
            List<char> list = new List<char>();
            for (int i = 0; i < ar.Length; i++)
            {
                if (!list.Contains(ar[i]))
                {
                    list.Add(ar[i]);
                }
            }
            list.Sort();
            foreach (char a in list)
            {
                Console.WriteLine(a + " ");
            }
        }
    }
}
