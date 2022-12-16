using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class Employee1
    {
        public int Id { get; set; }
            
        public string Name { get; set; }

        public int Salary { get; set; }


    }
    public class Program1
    {
        static void Main(string[] args)
        {
           
            Employee1[] arr1 = new Employee1[]
            {
                new Employee1{Id=101, Name="Brijesh", Salary=10254},
                new Employee1{Id=102, Name="Sanjay", Salary=15254},
                new Employee1{Id=103, Name="Abhi", Salary=10264},
                new Employee1{Id=104, Name="Akash", Salary=102454},
            };

            foreach   (Employee1 a in arr1)
            {
                Console.WriteLine($"{a.Id}  {a.Name}  {a.Salary}");
            }

           
        }
    }
}
