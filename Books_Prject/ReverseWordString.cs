using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ReverseWordString
    {
        static void Main(string[] args)
        {
            /* string str = Console.ReadLine();
             string rev = "";
             char[] ch = str.ToArray();
             rev = new string(ch);
             Array.Reverse(ch);
             bool b = str.Equals(rev);
             if(rev==str)
             {
                 Console.WriteLine("palindrome");

             }
             else
             {
                 Console.WriteLine("not");
             }*/

            /* int[] arr = new int[] { 4,5,7,2,3,1,7,8,6,4,9,2,13,14 };
             int[] arr2 = new int[3];

             Array.Sort(arr);
             Array.Reverse(arr);
             Array.Copy(arr, arr2, 3);
             foreach (var item in arr2)
             {
                 Console.WriteLine(item);
             }
             Array.Clear(arr, 0, 4);
             foreach (var i in arr)
             {
                 Console.WriteLine(i);
             }*/
            /* Product[] p = new Product[]
             {
                new Product{Pid=1, Pname="moues" },
                new Product{Pid=2, Pname="keyboard"}
            };
             foreach (Product item in p)
             {
                 Console.WriteLine($"{item.Pid} {item.Pname}");
             }*/
            /* string str = "test";
             string str1 = "test";
             string str2 = string.Concat(str, str1);
             Console.WriteLine(str2);
 */
            /* string str = "Hello to all";
            bool str1= str.StartsWith("hello");
             Console.WriteLine(str1);*/

            /* int a = 12;
             double d = 12.5;
             Console.WriteLine(a);
             Console.WriteLine(d);*/

            /*    int a = int.Parse(Console.ReadLine());*/
            /* int b = int.Parse(Console.ReadLine());*/
            /* int sum = a + b;
             Console.WriteLine(sum);*/
            /*double pi = 3.142;
            double area = pi * a * a;
            Console.WriteLine(area);*/
            /* double area = 0.5 * a * b;
             Console.WriteLine(area);*/

            /* if(a%2==0)
             {
                 Console.WriteLine("even");
             }
             else
             {
                 Console.WriteLine("odd");
             }
 */
            /* int n = int.Parse(Console.ReadLine());*/
            /*  if(n%5==0)
              {
                  Console.WriteLine("divisible by 5");
              }
              else
              {
                  Console.WriteLine("not divisible by 5");
              }*/

            /* if(n>0)
             {
                 Console.WriteLine("positive");
             }
             else if(n<0)
             {
                 Console.WriteLine("negative");
             }
             else
             {
                 Console.WriteLine("zero");
             }*/
            /* if(n%3==0)
              {
                  Console.WriteLine("divisible by3");

              }
              else if (n % 9 == 0)
              {
                  Console.WriteLine("divisible by 9");
              }*/
            int num = int.Parse(Console.ReadLine());
            int bvalue = 1;
            int rem;
            int devalue = 0;
            while(num>0)
            {
                rem = num % 10;
                devalue = devalue + rem * bvalue;
                num = num / 10;
                bvalue = bvalue * 2;
            }
            Console.WriteLine(devalue);
            


        }
    }
}
