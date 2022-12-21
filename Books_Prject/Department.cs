using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public enum Dtype { HR, Development, Testing}
    class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double Salary { set; get; }
        public Dtype Dtype;

       public  List<TypeOfDepartment> td = new List<TypeOfDepartment>();
    }
    public class TypeOfDepartment
    {
        public int DeptId { get; set; }
        public string Dname { get; set; }
    }
    public class DepartmentDetails
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>()
            {
                new Department
                {
                    Id=101,
                     Name="HR",
                     Dtype=Dtype.HR,
                     Salary=1200,
                     td=

                    {
                        new TypeOfDepartment{DeptId=1, Dname="E1" },
                        new TypeOfDepartment{DeptId=2, Dname="E2" },
                        new TypeOfDepartment{DeptId=3, Dname="E3" },
                    }
                },
                new Department
                {
                    Id=102,
                    Name="DEVELOPMENT",
                    Dtype=Dtype.Development,
                    Salary=1250,
                    td=
                    {
                        new TypeOfDepartment{DeptId=4, Dname="E4"},
                        new TypeOfDepartment{DeptId=5, Dname="E5"},
                        new TypeOfDepartment{DeptId=6, Dname="E6"},
                    }
                },
                new Department
                {
                    Id=103,
                    Name="TESTING",
                    Dtype=Dtype.Testing,
                    Salary=4523,
                    td =
                    {
                        new TypeOfDepartment{DeptId=7, Dname="E7"},
                        new TypeOfDepartment{DeptId=8, Dname="E8"},
                        new TypeOfDepartment{DeptId=8, Dname="E9"},
                    }
                }

            };
            foreach (Department item in departments)
            {
                Console.WriteLine($"ID :-{item.Id}, DNAME:-{item.Name}, SALARY:-{item.Salary}");

                foreach (TypeOfDepartment d in item.td)
                {
                    Console.WriteLine("Employee\t"+d.Dname);
                }
            }
        }
    }
}
