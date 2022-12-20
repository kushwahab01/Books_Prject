using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class MaxNumberArray
    {
        public void FindMax(int[,]a)
        {
            for(int i=0; i<a.GetLength(0); i++)
            {
                int max = a[0, i];
                for(int j=0; j<a.GetLength(1); j++)
                {
                    if(a[i,j]>max)
                    {
                        max = a[i, j];
                    }
                }

                Console.Write("Max value of row is :"+max);
                Console.WriteLine();
            }
           
           
        }

        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];
            Console.WriteLine("Enter an element");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j]= Convert.ToInt32(Console.ReadLine());
                }


            }

            // int[,] arr = { { 1, 2, 3, 8 }, { 5, 4, 6, 7 }, { 454, 55, 8, 5 } };

            MaxNumberArray m = new MaxNumberArray();
            m.FindMax(arr);
        }
    }
}
