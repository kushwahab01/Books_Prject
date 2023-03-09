using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Books_Prject
{
    internal class RemoveSpace
    {
        /* public void Replace1(string str)
         {
             // Remove white space in string
             string pattern = "\\s+";
             string replacement = " ";
             Regex rx = new Regex(pattern);
             string res = rx.Replace(str, replacement);

             Console.WriteLine("Your string String    :{0}",str);
             Console.WriteLine("Remove extra space string   :{0}", res);
         }
         static void Main(string[] args)
         {
             Console.WriteLine("Enter the string");
             string str = Console.ReadLine();
             RemoveSpace rs = new RemoveSpace();
             rs.Replace1(str);
         }*/

        /* public int Occcurence(string str, string str1)
         {
             string[] a = str.Split(' ');
             int count = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 if (str1.Equals(a[i]))

                     count++;

             }
             return count;
         }
         static void Main(string[] args)
         {
             Console.WriteLine("Enter the string 1");
             string str = Console.ReadLine();
             Console.WriteLine("Enter the string 2");
             string str1 = Console.ReadLine();

         }*/
        HashSet<int> list = new HashSet<int>();
       

    }
}
