using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class MaxNumber
    {
        public int FindMax(int[] a)
        {
            int max = 0;
            for(int i=0; i<a.Length; i++)
            {
                if(max<a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }
        public class FindElement
        {
            static void Main(string[] args)
            {
                int[] arr = new int[5];
                Console.WriteLine("Enter the element");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());

                }
                MaxNumber m = new MaxNumber();
                Console.WriteLine(m.FindMax(arr));
            }
        }
    }
}
