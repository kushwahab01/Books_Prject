using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class CollectionsDemo
    {

        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(10);
            l.Add(20);
            l.Add(30);
            l.Add(40);
            l.Add(50);
            Console.WriteLine("Count of element is "+l.Count);

            foreach (var item in l)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(".............................................");

            List<string> l1 = new List<string>();
            l1.Add("Brijesh");
            l1.Add("Sanjeev");
            l1.Add("Abhi");
            l1.Add("Akash");

            foreach (var i in l1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine( "...................................................");

            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);

            foreach (var j in s)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("..........................................");
            Stack<string> s1 = new Stack<string>();
            s1.Push("Hi");
            s1.Push("Hello");
            s1.Push("EveryOne");

            foreach (var k in s1)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("..........................................");
            Queue<int> q = new Queue<int>();
            q.Enqueue(54);
            q.Enqueue(2);
            q.Enqueue(65);
            q.Enqueue(22);

            foreach (var m in q)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine(".............................................");

            Dictionary<int, int> d = new Dictionary<int, int>();
            d.Add(10, 20);
            d.Add(62, 52);
            d.Add(66, 5);

            foreach (KeyValuePair<int, int> n in d)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("......................................");
            Dictionary<string, int> d1 = new Dictionary<string, int>();
            d1.Add("hii",100);
            d1.Add("Hello", 200);
            d1.Add("Everyone", 300);

            foreach (KeyValuePair<string,int> one in d1)
            {
                Console.WriteLine(one);
            }


            Console.WriteLine("..................................");
            Dictionary<string, double> d2 = new Dictionary<string, double>();
            d2.Add("hiii", 12.5);
            d2.Add("hello", 45.24);

            foreach (KeyValuePair<string,double> two in d2)
            {
                Console.WriteLine(two);
            }

            Console.WriteLine(".....................................");

            SortedList<string, int> s3 = new SortedList<string, int>();
            s3.Add("hii", 1);
            s3.Add("hello", 5);
            s3.Add("everyone", 3);
            s3.Add("How are you", 4);

            foreach (KeyValuePair<string, int> three in s3)
            {
                Console.WriteLine(three);
            }

            Console.WriteLine("..........................................");

            
        }
    }
}
