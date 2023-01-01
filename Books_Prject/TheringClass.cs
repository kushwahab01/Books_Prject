using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Books_Prject
{
    class TheringClass
    {
        public void M1()
        {
            lock (this)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    //Thread.Sleep(1000);
                }
            }
        }
        public void M2()
        {
            for(int i=11; i<=20; i++)
            {
                Console.WriteLine(i);
               // Thread.Sleep(1000);
            }
        }
    }
    public class MulThred
    {
        static void Main(string[] args)
        {
            TheringClass t = new TheringClass();
            Thread t1 = new Thread(new ThreadStart(t.M1));
            Thread t2 = new Thread(new ThreadStart(t.M2));
            t1.Start();
           // t1.Join();
            t2.Start();
        }
    }
}
