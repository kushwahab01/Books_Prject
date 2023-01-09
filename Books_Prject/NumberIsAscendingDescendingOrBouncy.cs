using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class NumberIsAscendingDescendingOrBouncy
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int n1 = Convert.ToInt32(string.Concat(n.ToString().OrderByDescending(x=>x)));

           // Console.WriteLine(n1);

            int n2 = Convert.ToInt32(string.Concat(n.ToString().OrderBy(x => x)));
           // Console.WriteLine(n2);

            if(n==n1)
            {
                Console.WriteLine("Descendig");
            }
            else if(n==n2)
            {
                Console.WriteLine("Ascending");
            }
            else
            {
                Console.WriteLine("Ducket");
            }
        }
    }
}
