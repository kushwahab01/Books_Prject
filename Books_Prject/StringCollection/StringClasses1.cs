using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class StringClasses1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string 1");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the string 2");
            string str1 = Console.ReadLine();



            string s = string.Concat(str, str1);
            Console.WriteLine("The Concatinatig string is: " + s);

            bool result = str.StartsWith("Hello");
            Console.WriteLine(result);

            bool result1 = str.EndsWith("you");
            Console.WriteLine(result1);

            bool res = str.Contains("Hello");
            Console.WriteLine(res);

            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());

            char[] ch = str.ToCharArray();


            foreach (var item in ch)
            {
                Console.WriteLine(" " + item);
            }

            int b = string.Compare(str, str1);
            Console.WriteLine(b);



        }
    }
}
