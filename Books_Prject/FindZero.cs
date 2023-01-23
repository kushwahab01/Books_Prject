using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class FindZero
    {/*
        static int FindZeroEle(int[] arr, int n)
        {
            int count = 0;
            for(int i=0; i<n; i++)
            {
                if(arr[i]==0)
                {
                   return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int n = arr.Length;
            int x = FindZeroEle(arr, n);
            if(x==-1)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(n-x);
            }


        }
    }*/
        /* public  int firstZero(int[] arr, int low, int high)
          {
              if (high >= low)
              {

                  int mid = low + (high - low) / 2;
                  if ((mid == 0 || arr[mid - 1] == 1) &&
                                       arr[mid] == 0)
                      return mid;

                  if (arr[mid] == 1) 
                      return firstZero(arr, (mid + 1), high);

                  else 
                      return firstZero(arr, low, (mid - 1));
              }
              return -1;
          }

          int countZeroes(int[] arr, int n)
          {
              int first = firstZero(arr, 0, n - 1);

              if (first == -1)
                  return 0;

              return (n - first);
          }

          public static void Main()
          {
              FindZero count = new FindZero();

              int[] arr = new int[10];
              for(int i=0; i<arr.Length; i++)
              {
                  arr[i] = int.Parse(Console.ReadLine());
              }
              int n = arr.Length;
              Console.WriteLine(count.countZeroes(arr, n));

          }*/
        /*static int __gcd(int a, int b)
        {
           
            if (a == 0 || b == 0)
                return 0;

            if (a == b)
                return a;

            if (a > b)
                return __gcd(a - b, b);

            return __gcd(a, b - a);
        }

        static void coprime(int a, int b)
        {

            if (__gcd(a, b) == 1)
                Console.WriteLine("Co-Prime");
            else
                Console.WriteLine("Not Co-Prime");
        }
        public static void Main()
        {
            //int a = 5, b = 6;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            coprime(a, b);
          
        }
*/

        /* static void Main(string[] args)
         {
             int n1 = int.Parse(Console.ReadLine());
             int n2 = int.Parse(Console.ReadLine());
             int gcd = 1;
             for (int i = 1; i <= n1 && i <= n2; ++i)
             {
                 if (n1 % i == 0 && n2 % i == 0)

                     gcd = i;
             }
                 if(gcd==1)
                     {
                     Console.WriteLine("Coprime");
                 }
                 else
                 {
                     Console.WriteLine("not co prime");
                 }

         }*/

        static int findSubArray(int[] arr, int n)
        {
            int sum = 0;
            int maxsize = 0, startindex = 0;
            int endindex = 0;

            // Pick a starting point as i
            for (int i = 0; i < n - 1; i++)
            {
                sum = (arr[i] == 0) ? -1 : 1;

                // Consider all subarrays starting from i

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] == 0)
                        sum += -1;
                    else
                        sum += 1;

                    // If this is a 0 sum subarray, then
                    // compare it with maximum size subarray
                    // calculated so far

                    if (sum == 0 && maxsize < j - i + 1)
                    {
                        maxsize = j - i + 1;
                        startindex = i;
                    }
                }
            }
            endindex = startindex + maxsize - 1;
            if (maxsize == 0)
                Console.WriteLine(maxsize);
            else
                Console.WriteLine(maxsize);

            return maxsize;
        }

       
        public static void Main()
        {

            
            int[] arr = new int[6];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int size = arr.Length;
            findSubArray(arr, size);
        }
    
}
}
