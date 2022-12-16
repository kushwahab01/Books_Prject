using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public class EmployeeClass: IComparable
    {
        private string name;
        private int id;
        private double salary;

        public EmployeeClass(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public int CompareTo(object obj)
        {
            EmployeeClass e4 = (EmployeeClass)obj;
            if(this.salary > e4.salary)
            {
                return 1;
            }
            else if(this.salary < e4.salary)
            {
                return -1;

            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{name}  {id}  {salary}";
        }

    }
    public class Emp:IEnumerable
    {
        private EmployeeClass[] employeeClasses;
        public Emp()
        {
            employeeClasses = new EmployeeClass[5];
            employeeClasses[0] = new EmployeeClass("Brijesh", 01, 2000);
            employeeClasses[1] = new EmployeeClass("Sajeev", 02, 12000);
            employeeClasses[2] = new EmployeeClass("abhi", 03, 5000);
            employeeClasses[3] = new EmployeeClass("akash", 04, 6000);
            employeeClasses[4] = new EmployeeClass("rahul", 05, 26000);
        }

        public IEnumerator GetEnumerator()
        {
            return employeeClasses.GetEnumerator();
        }
        
        
    }

    public class Employees
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            
            foreach (EmployeeClass b in e)
            {
                Console.WriteLine(b);
            }
            EmployeeClass employeeClasse1 = new EmployeeClass("Brijesh", 01, 2000);
            EmployeeClass employeeClasse2 = new EmployeeClass("Sajeev", 02, 12000);
            EmployeeClass employeeClasse3 = new EmployeeClass("abhi", 03, 5000);
            EmployeeClass employeeClasses4 = new EmployeeClass("akash", 04, 6000);
            EmployeeClass employeeClasses5 = new EmployeeClass("rahul", 05, 26000);

            int result = employeeClasse1.CompareTo(employeeClasses4);
            if (result == 1)
            {
                Console.WriteLine("Brijesh has more salary than akash");
            }
            else if (result == -1)
            {
                Console.WriteLine("Brijesh has less salary than akash");
            }
            else
            {
                Console.WriteLine("Brijesh & akash both has same salary");
            }

        }
    }


}
