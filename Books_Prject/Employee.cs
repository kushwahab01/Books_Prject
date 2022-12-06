using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public class Employee
    {
        private string name;
        private int id;
        private double salary;
        private static  int count;
        private string country;
        public Employee(string name, double salary, string country="India")
        {
            count++;
            id = count;
            this.name = name;
            this.salary = salary;
            this.country = country;

        }
        public override string ToString()
        {
            return $"{name}-->{id}-->{salary}-->{country}";
        }
        static void Main(string[] args)
        {
            Employee e = new Employee("Brijesh", 245600.0);
            Employee e1 = new Employee("Sanjay", 25000.15);
            Employee e2 = new Employee("Abhishek", 354600.05);

            Console.WriteLine(e);
            Console.WriteLine(e1);
            Console.WriteLine(e2);
        }
    }
}
