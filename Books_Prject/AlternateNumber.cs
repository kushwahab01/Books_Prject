using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class AlternateNumber
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter an element");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            for(int i=0; i<arr.Length; i+=2)
            {
                Console.WriteLine("Alternate array element is: "+arr[i]);
            }
            

        }
    }
}
