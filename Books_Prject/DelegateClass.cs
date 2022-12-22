using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public delegate int  MyDel1(int n1, int n2);
    public delegate string MyDel2(string s);
    class DelegateClass
    {
       public int M1(int a, int b)
        {
            return a + b;
        }
        public string M2(string name)
        {
            return name.ToUpper();
        }

    }
    public class DeligateDemo
    {
        static void Main(string[] args)
        {
            DelegateClass d = new DelegateClass();

            MyDel1 myDel1 = new MyDel1(d.M1);

            MyDel2 myDel2 = new MyDel2(d.M2);

            int sum = myDel1.Invoke(12, 14);

            string name = myDel2.Invoke("brijesh");

            Console.WriteLine(sum);
            Console.WriteLine(name);
        }
    }
}
