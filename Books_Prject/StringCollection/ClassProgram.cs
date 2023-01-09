using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ClassProgram
    {
        static void Main(string[] args)
        {
           
            string s = Console.ReadLine();
            string[] str = s.Split();

            for(int i=0; i<=str.Length; i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write(" "+str[j]);
                }
                Console.WriteLine();
            }
                      
        }
    }
}
//Output

/*india
  india is
  india is my
  india is my country
*/