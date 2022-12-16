using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ConcatString
    {
        static void Main(string[] args)
        {
           /* string s1 = "test";
            string s2 = "Test";

            bool str = s1.Equals(s2);
            Console.WriteLine(str);
*/
            StringBuilder sb = new StringBuilder();
            double price = 45000;
            sb.AppendFormat("Price is {0:C}",price);
            Console.WriteLine(sb);
        }
    }
}
