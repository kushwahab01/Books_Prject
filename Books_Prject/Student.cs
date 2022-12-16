using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class Student
    {
        private string name;
        private int id;
        private double marks;
        private string address;
        private static int count;

        public Student(string name, double marks, string address, string country = "India")
        {
            count++;
            id = count;
            this.name = name;
            this.marks = marks;
            this.address = address;
            

        }
        public string Name
        {
            set;
            get;
        }
        public double Marks
        {
            set;
            get;

        }
        public string Address
        {
            set;
            get;
        }

        public override string ToString()
        {
            return $"{id}-->{name}-->{marks}-->{address}";
        }
        static void Main(string[] args)
        {
            Student s = new Student("Brijesh", 80.84, "Pune");
            Student s1 = new Student("Sanjeev", 80.85, "Mumbai");
            Student s2 = new Student("Abhi", 80.86, "Banglore");

            Console.WriteLine(s);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
