using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class NewClasArray
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
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            NewClasArray n = new NewClasArray();
            
            Console.WriteLine(n.FindMax(arr));
        }
    }
}
