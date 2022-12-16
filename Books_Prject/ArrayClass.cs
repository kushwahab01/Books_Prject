using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ArrayClass
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 6, 1,7, 9, 2, 4, 6, 5, 9, 6, 2, 4, 6, 2, 3, 8, 9 };
            /*Array.Sort(arr);
            Array.Reverse(arr);*/
            //Array.Clear(arr, 5, 9);
            int[] arr1 = new int[3];
            
            //Array.Copy(arr, arr1, 3);

           
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}
