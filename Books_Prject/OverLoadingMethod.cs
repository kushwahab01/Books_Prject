using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class OverLoadingMethod
    {
        
            public int Add(int a, int b)
            {
                return a + b;
            }
            public int Add(int a, int b, int c)
            {
                return a + b + c;

            }
            public double Add(int a, double d)
            {
                return a + d;
            }
            public double Add(double d, double b)
            {
                return d + b;
            }
            public string Add(string a, string b)
            {
                return a + b;
            }
        
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 5);
            r.CalculateArea();
            Console.WriteLine(r);
            
        
        
        }
    }
}
