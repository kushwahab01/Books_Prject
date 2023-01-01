using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class StringClasses
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 4, 8, 8, 7, 9, 32, 4, 5, 2, 5, 5, 2, 4, 5, 5 };
            int[] arr2 = new int[5];

            Array.Copy(arr, 7, arr2, 0, 1);
//          Array.Sort(arr);
           // Array.Reverse(arr);
            Array.Copy(arr, arr2, 3);
            Array.Copy(arr, 4, arr2,0, 5);
            Array.Clear(arr, 6, 3);


            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
