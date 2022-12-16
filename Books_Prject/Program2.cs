using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class Program2
    {
        static void Main(string[] args)
        {
            EnumClasses em = new EnumClasses(101, "Brijesh", 14202, Dept.Development);
            EnumClasses em1 = new EnumClasses(102, "sanjay", 1422, Dept.HR);
            EnumClasses em2 = new EnumClasses(103, "abhi", 14225, Dept.Admin);
            EnumClasses em3 = new EnumClasses(104, "akash", 1422, Dept.Manager);

            em.Calc();
            em1.Calc();
            em2.Calc();
            em3.Calc();
            Console.WriteLine(em);
            Console.WriteLine(em1);
            Console.WriteLine(em2);
            Console.WriteLine(em3);
        }
        
       
    }
}
