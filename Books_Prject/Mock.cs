using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Books_Prject
{
    internal class Mock
    {
        //str1=brijesh
        //str2=DotNetmvc

        //o/p-bDroitjNeesthmmvc
        static void Main(string[] args)
        {
            /*  string str2 = "brijesh";
              string str1 = "DotNetmvc";
              string str3 = "";
              for(int i=0; i<str1.Length || i<str2.Length; i++)
              {
                  if (i < str1.Length)
                  {
                      str3 += str1[i];
                  }
                  if(i<str2.Length)
                  {
                      str3 += str2[i];
                  }
              }
              Console.WriteLine(str3);
             */
            /*int[] arr = { 5, 6, 7, 8 };
            int[] arr1 = { 9, 10, 11, 12, };
            int[] arr2 = new int[8];
            int k = 0;
            for(int i=0; i<arr.Length; i++)
            {
                arr2[k] = arr[i];
                k++;
            }
            for(int i=0; i<arr1.Length; i++)
            {
                arr2[k] = arr1[i];
                k++;
            }
            foreach (int item in arr2)
            {
                Console.WriteLine(item);
            }*/

            /*  HashSet<int> ints = new HashSet<int>();
              ints.Add(10);
              ints.Add(10);
              ints.Add(20);
              ints.Add(30);
              ints.Add(50);
              ints.Add(10);
              ints.Add(20);
              ints.Add(30);

              foreach (var item in ints)
              {
                  Console.WriteLine(item);
              }*/
            /* Console.WriteLine("Enter the number");
             int n = int.Parse(Console.ReadLine());
             int a = 0;
             for(int i=1; i<=n; i++)
             {
                 if(n%i==0)
                 {
                     a++;
                 }

             }
             if (a == 2)
             {
                 Console.WriteLine("Prime");
             }
             else
             {
                 Console.WriteLine("not prime");
             }*/

            /* string str = Console.ReadLine();
             string str1 = "";
             char[] arr = str.ToArray();
             Array.Reverse(arr);
             str1 = new string(arr);
             if(str.Equals(str1))
             {
                 Console.WriteLine("palindrome");
             }
             else
             {
                 Console.WriteLine("not palindrome");
             }*/

            /*   string str = "nayana";
               string rev = "";
               char[] ch = str.ToArray();
               Array.Reverse(ch);
               rev = new string(ch);
               if(str.Equals(rev))
               {
                   Console.WriteLine("palindrome");
               }
               else
               {
                   Console.WriteLine("not palindrome");
               }*/

            /*int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int max = arr[0]; int min = arr[0];
            for(int i=1; i<arr.Length; i++) {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
                if (arr[i]<min)

                {
                    min = arr[i];
                }
               
            }
            Console.WriteLine("value of max"+max);
            Console.WriteLine("value of min: "+min);
       */
            /* int a = 0, b = 1, c;
             int n = int.Parse(Console.ReadLine());
             Console.WriteLine(a);
             Console.WriteLine(b);
             do
             {
                 c = a + b;
                 a = b;
                 b = c;
                 Console.WriteLine(c);
             } while (c < n - a);
 */
            /* int a = 0, b = 1, c;
             int n = int.Parse(Console.ReadLine());

             Console.WriteLine(a);
             Console.WriteLine(b);
             do
             {
                 c = a + b;
                 a = b;
                 b = c;
                 Console.WriteLine(c);
             } while (c < n - a);*/

            /* int year = int.Parse(Console.ReadLine());
             if(((year%4==0)&&(year/100!=0) )||(year/400==0)) {
                 Console.WriteLine(" leap year");

             }
             else
             {
                 Console.WriteLine("not leap year");
             }
         }*/

            /* int n, lastd, temp, sum = 0;
             n=int.Parse(Console.ReadLine());
             temp = n;
             while(n>0)
             {
                 lastd = n % 10;
                 sum = sum + (lastd * lastd * lastd);
                 n = n / 10;
             }
             if(temp==sum)
             {
                 Console.WriteLine("number is armstrong");
             }
             else
             {
                 Console.WriteLine("not armstrong");
             }*/
            /*int fact = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
*/
            /*
                        int[] arr = { 12, 5, 7, 6, 34, 24 };
                        int max = arr[0];
                        int min = arr[0];
                        for(int i=0; i<arr.Length; i++)
                        {
                            if (arr[i]>max)
                            {
                                max= arr[i];
                            }
                            if (arr[i]<min)
                            {
                                min = arr[i];
                            }

                        }
                        Console.WriteLine("max num is :" + max);
                        Console.WriteLine("min num is :" + min);*/
            /* Console.WriteLine("enter the number");
             int n = int.Parse(Console.ReadLine());
             int a = 0;
             for(int i=1; i<=n; i++)
             {
                 if(n%i==0)
                 {
                     a++;
                 }

             }
             if(a==2)
             {
                 Console.WriteLine("prime");
             }
             else
             {
                 Console.WriteLine("");
             }*/

            /* int temp;
             int a=10; int b=20;
             int n = int.Parse(Console.ReadLine());



                 temp = a;
                 a = b;
                 b = temp;

             Console.WriteLine("value of a is :"+a);
             Console.WriteLine("value of b is :"+b);*/
            /* Console.WriteLine("Enter the size");
             int n = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the element");
             int[] arr = new int[n];
             for(int i=0; i<arr.Length; i++)
             {
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine("Even number");
             for(int i=0; i<n; i++)
             {
                 if (arr[i] %2==0)
                 {
                     Console.Write(arr[i]+" ");
                 }
             }
             Console.WriteLine();
             Console.WriteLine("Odd Number");
             for(int i=0; i<n; i++)
             {
                 if (arr[i] %2!=0)
                 {
                     Console.Write(arr[i]+" ");
                 }
             }
             Console.WriteLine();*/


            /*  string[] arr = new string[] { "brijesh", "rajesh", "Ramesh","adarsh","abhinandan" };
              Console.WriteLine(arr.Length);
              Console.WriteLine(arr[1]);
              arr.ToArray();
              Array.Reverse(arr);
              string[] rev = new string[2];
              Array.Sort(arr);
              arr.Clone();
              foreach (var item in arr)
              {
                  Console.WriteLine(item);
              }*/
            /* int[] arr=new int[] { 1, 2, 3,4, 5, 6,7 };
             int max = arr[0];
             int min = arr[0];
             for(int i=1; i<arr.Length; i++)
             {
                 if (arr[i]>max)
                 {
                     max = arr[i];
                 }
                 if (arr[i]<min)
                 {
                     min = arr[i];
                 }

             }
             Console.WriteLine("Max is :"+max);
             Console.WriteLine("Min is :"+min);
 */
            /*  string str = "nayan";
              string rev = "";
              char[] ch = str.ToCharArray();
              Array.Reverse(ch);
              rev = new string(ch);
              if(rev==str)
              {
                  Console.WriteLine("palindrome");
              }
              else
              {
                  Console.WriteLine("not palindrome");
              }*/

            /*int n = int.Parse(Console.ReadLine());
            int a = 0;
            for(int i=1; i<=n; i++) { 
            if(n%i==0)
                {
                    a++;
                }
            }
            if(a==2)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }*/
            /*  int n = int.Parse(Console.ReadLine());
              int a = 0, b = 1, c;
              Console.WriteLine(a);
              Console.WriteLine(b);
              do
              {
                  c = a + b;
                  a = b;
                  b = c;
                  Console.WriteLine(c);
              } while (c <n - a);
  */
            /*int lastdigit, n, temp, sum = 0;
            n = int.Parse(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                lastdigit = n % 10;
                sum = sum + (lastdigit * lastdigit * lastdigit);
                n = n / 10;
            }
           if(temp==sum)
            {
                Console.WriteLine("armstrog");
            }
            else
            {
                Console.WriteLine("not armstrong");
            }*/

            /* int[] arr = new int[] { 8, 6, 4, 6, 44, 9, 3, 4, 3, 5, 6, 3, 4, 6, 6, 7 };

             int[] arr1 = new int[5];

             for (int i = 0; i < arr.Length; i++)
             {
                for(int j=i+1; j<arr.Length; j++)
                 {
                     if (arr[i] == arr[j])
                     {
                         arr1[i] = arr[i];
                     }
                 }
                 Console.WriteLine(arr1[i]);
             }*/

            //Array.Copy(arr,6,arr1,1,2);
            /* Array.Sort(arr);
             Array.Reverse(arr);*/
            // Array.Clear(arr, 2, 5);
            /* foreach (var item in arr)
             {
                 Console.WriteLine(item);
             }*/
            int[] a1 = { 1, 4, 5 };
            int[] a2 = { 6, 7, 8, 9, 10 };
            List<int> list = new List<int>();
            int[] a3 = new int[8];
            int k = 0;
            for(int i=0; i<a1.Length; i++)
            {
                a3[k++] = a1[i];
                
                 }
            for(int i=0; i<a2.Length; i++)
            {
                a3[k++] = a2[i];
            }
            for(int i=0; i<a3.Length; i++)
            {
                for(int j=i+1; j<a3.Length; j++)
                {
                    if (a3[i] == a3[j])
                    {
                        a3[i] = 0;
                    }
                }
            }
            foreach (var item in a3)
            {
                Console.WriteLine(item);
            }

        }
    }
}
