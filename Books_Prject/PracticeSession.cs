using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{       //Split string into 2 token
  /* public class PracticeSession
    {
        static void Main(string[] args)
        {
            string str = "HELLO$WORLD";
            string[] arr = str.Split('$');
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }*/


    public class MaxMinSeperate
    {
        static void Main(string[] args)
        {
            /*int[] arr = new int[] { 1, 2, 3, 4, 5, 6, };
            int num = arr.Length;
            int max = arr[0];
            int min = arr[0];
           for(int i=1; i<num; i++)
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
            Console.WriteLine("max number is :"+max +" "+"min number is :"+min);
*/
            /*          //Q.1split string into 2 token
                        string str = "HELLO$WORLD";
                        string[] arr= str.Split('$');
                        foreach (string s in arr)
                        {
                            Console.WriteLine(s);
                        }*/

            //@.2 Write a C# program to count occurrences of a character in given string

            /* string str = "I like India";
             char[] ch= str.ToCharArray();
             for(int i=0; i<ch.Length-1; i++)
             {
                 int count = 1;
                 for(int j=i+1; j<ch.Length; j++)
                 {
                     if (ch[i] == ch[j])
                     {
                         count++;
                         ch[j] = '0';
                     }
                 }
                 if (ch[i]!='0' && ch[i]!=' ')
                 {
                     Console.WriteLine(ch[i]+" Occourence"+" "+count);
                 }
             }*/

            // Write a C# program to toggle case of each character of a string

            /* Product[] p = new Product[]
             {
                 new Product{Pid=1,Pname="Mouse" },
                 new Product{Pid=2,Pname="keyboard" },
                 new Product{Pid=3,Pname="desktop" },
                 new Product{Pid=4,Pname="cpu" }
             };
             foreach (Product item in p)
             {
                 Console.WriteLine($"{item.Pid}  {item.Pname}");
             }*/
            // int[] arr = { 15, 58, 5, 6, 7, 8, 9, 10, 11,12 };
            // Console.WriteLine("max element is :"+arr.Max());
            //Console.WriteLine("max element is :"+arr.Min());

            /* double sum = arr.Sum();
             double avg = arr.Average();
             int cuunt = arr.Count();
             Console.WriteLine(cuunt);
             Console.WriteLine(sum);
             double avrg = sum / cuunt;
             Console.WriteLine(avrg);
             Console.WriteLine(avg);*/
            /*  Array.Sort(arr);
            for(int i=arr.Length-1; i>0; i--)
              {
                  Console.WriteLine(arr[i]);
              }*/
            /* int[] arr = { 15, 58, 5, 6, 7, 8, 9, 10, 11, 12 };
             int max = arr[0];
             for (int i=1; i<arr.Length; i++)
             {

                 for(int j=i+1; i<arr.Length; j++)
                 {
                     if (arr[i] < arr[j])
                     {
                        max= arr[i];
                     }
                 }
                 Console.WriteLine(max);
             }*/


            int[] arr = new int[] { 15, 58, 5, 6, 7, 8, 9, 10, 11, 12 };
            /* int count = arr.Count();*/
            // Console.WriteLine(count);

            // Array.Sort(arr);
            /* for(int i=arr.Length-1; i>0; i--)
             {
                 // Console.WriteLine(arr[i]);
                 Console.WriteLine(arr[5]);
             }
           */
            /* Console.WriteLine(arr[6]);
             Array.Sort(arr);*/

            /* int max = arr[0];
             int min = arr[0];
             for (int i=1; i<arr.Length;i++) {

                 if (arr[i]>max)
                 {
                     max = arr[i];
                 }
                 if (arr[i]<min)
                 {
                     min = arr[i];
                 }

             }
             Console.WriteLine(max);
             Console.WriteLine(min);
         }*/
            /* int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 } };
             for(int i=0; i<arr1.GetLength(0); i++)
             {
                 for(int j=0; j<arr1.GetLength(1); j++)
                 {
                     Console.Write(arr1[i,j]+" ");
                 }
                 Console.WriteLine();
             }*/
/*
            int[,,] arr2 = { {{ 1, 2, 3,4 }, { 2, 3, 4,5 }, { 3, 4, 5,9 }, { 4, 5, 6,8 } } }; 
           for(int i=0; i<arr2.GetLength(0); i++)
            {
                for(int j=0; j<arr2.GetLength(1); j++)
                {
                    for(int k=0; k<arr2.GetLength(2); k++)
                    {
                        if (arr2[,j,]==1 && arr2[j]==4)
                        {

                        }
                    }
                    Console.WriteLine();
                }
               
            }*/


                
           
        }

    }
}
