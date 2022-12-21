using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class FindMinimumAtArray
    {
        public int FindMin(int[] a)
        {
            int min = 0;
            for(int i=0; i<a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
               
            }
            return min;
        }
        static void Main(string[] args)
        {
           
            int[] arr = new int[10];
            Console.WriteLine("Enter an element");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            FindMinimumAtArray f = new FindMinimumAtArray();
           
            Console.WriteLine(f.FindMin(arr));
        }
    }
}
