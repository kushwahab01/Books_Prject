using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] =Convert.ToInt32(Console.ReadLine());
            }
            SwipNumber s = new SwipNumber();
            Console.WriteLine("......................");
            s.SwipeNumber1(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("..........................");
            s.SwipeNumber2(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
