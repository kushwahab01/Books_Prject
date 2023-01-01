using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public class ArrayAlternate
    {
        public void Fun(int[] a, int[] b)
        {
            int n = a.Length;
            int m = b.Length;
            int[] ans = new int[n + m];
            int i = 0, j = 0, k = 0;
            while(i<n && j<m)
            {
                ans[k++] = a[i++];
                ans[k++] = b[j++];

            }
            while (i<n)
            {
                ans[k++] = a[i++];
            }
            while(j<m)
            {
                ans[k++] = b[j++];
            }
            Console.WriteLine(string.Join(" ", ans));
        }
        public class FunArray
        {
            static void Main(string[] args)
            {
                int[] arr = new int[] { 1, 2, 3, 4, 5, 6, }
                    int[] arr1 = new int[] { 7, 8, 9, 10, 11, 12, 13 }
                    int[] arr2 = new int[13]
                    ArrayAlternate a = new ArrayAlternate();
                a.Fun(arr, arr1);
                Console.WriteLine(a);
            }

        }
    }
}
