using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ListCollections
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            char[] arr = data.ToCharArray();
            List<char> list = new List<char>();
            for(int i=0; i<arr.Length; i++)
            {
                if(!list.Contains(arr[i]))
                {
                    list.Add(arr[i]);
                }
            }
            list.Sort();
            foreach (char item in list)
            {
                Console.WriteLine(item+" ");
            }
        }
       
    }
}
