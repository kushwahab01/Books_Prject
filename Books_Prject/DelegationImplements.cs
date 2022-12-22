using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public delegate int Mydel(int n1, int n2);
    public delegate string MyString(string s);
    public class DelegationImplements
    {
        public int M1(int a, int b)
        {
            return a + b;
        }
        public int M3(int a, int b)
        {
            return a - b;
        }
        public  int M4(int a, int b)
        {
            return a * b;
        }
        public string M2(string name)
        {
            return name.ToUpper();
        }
    }
    public class DelDetails
    {
        static void Main(string[] args)
        {
            DelegationImplements d = new DelegationImplements();
            Mydel d1 = new Mydel(d.M1);
            d1 += new Mydel(d.M3);
            d1 += new Mydel(d.M4);

            Delegate[] list = d1.GetInvocationList();
            foreach  (Delegate b in list)
            {
                Console.WriteLine(b.Method);
                Console.WriteLine(b.DynamicInvoke(15,45));
            }

            

            

             
        }
    }
}
