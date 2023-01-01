using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject.StringCollection
{
    class SplitString
    {
        static void Main(string[] args)
        {
            string str = "HELLO$WORLD";

            char[] seperator = { '$', ' ' };

            string[] strlist = str.Split(seperator);

            foreach (string item in strlist)
            {
                Console.WriteLine(item);
            }

        }
    }
}
