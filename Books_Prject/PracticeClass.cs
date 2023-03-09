using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public class PracticeClass
    {
        //Count the alphabates,number,special character to the given string

        /* static void Main(string[] args)
         {
             int alaphabates, num, splchar, i;
             i = alaphabates = num = splchar = 0;

             Console.WriteLine("Enter the string");
             string str = Console.ReadLine();

             int l= str.Length;
             while (i<l)
             {
                 if ((str[i]>='a' && str[i]<='z') || (str[i]>='A' && str[i]<='Z'))
                 {
                     alaphabates++;
                 }
                 else if (str[i]>='0' && str[i]<='9')
                 {
                     num++;
                 }
                 else
                 {
                     splchar++;
                 }
                 i++;
             }
             Console.WriteLine("Number of Character is"+alaphabates);
             Console.WriteLine("count of number is"+num);
             Console.WriteLine("count of special char is"+splchar);

         }*/

        // Find Max Number from array 
        /* public int FindMax(int[] a)
         {
             int max = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 if (max < a[i])
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
                 PracticeClass m = new PracticeClass();
                 Console.WriteLine(m.FindMax(arr));
             }
         }*/

        static void Main(string[] args)
        {
            int[] arr= {1,2,3,4,5};
            for(int i=0; i<arr.Length; i+=2)
            {
                Console.WriteLine(arr);
            }
        }
    }
}
