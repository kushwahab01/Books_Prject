using System;
using System.Collections.Generic;
using System.Linq;


namespace Books_Prject
{
    internal class LinQProgram
    {
        static void Main(string[] args)
        {
            List<EmployeeDetails> emp = new List<EmployeeDetails>()
            {
                new EmployeeDetails{Eid=101, EmpName="Briijesh", Salary=45000, DeptName="Dev" },
                new EmployeeDetails{Eid=102, EmpName="Abhishek", Salary=44000, DeptName="HR" },
                new EmployeeDetails{Eid=103, EmpName="Sanjeev", Salary=30000, DeptName="Calling" },
                new EmployeeDetails{Eid=104, EmpName="Akash", Salary=25000, DeptName="Finance" },
                new EmployeeDetails{Eid=105, EmpName="Shubham", Salary=75000, DeptName="Testing" },
                new EmployeeDetails{Eid=106, EmpName="Rajesh", Salary=32000, DeptName="Managing" },
                new EmployeeDetails{Eid=107, EmpName="Rahul", Salary=40000, DeptName="HR" },
                new EmployeeDetails{Eid=108, EmpName="Rutik", Salary=36000, DeptName="Dev" },
                new EmployeeDetails{Eid=109, EmpName="Mahesh", Salary=15000, DeptName="Support" },
                new EmployeeDetails{Eid=110, EmpName="Ganesh", Salary=24000, DeptName="Finance" },
                new EmployeeDetails{Eid=111, EmpName="Ajay", Salary=35000, DeptName="Calling" },
                new EmployeeDetails{Eid=112, EmpName="Arun", Salary=65000, DeptName="Testing" },
                new EmployeeDetails{Eid=113, EmpName="Dinesh", Salary=51000, DeptName="Dev" },
                new EmployeeDetails{Eid=114, EmpName="Krushna", Salary=20000, DeptName="Dev" },
            };

            var result = from e in emp
                         select e;
            foreach (EmployeeDetails item in result)
            {
                Console.WriteLine(item);
            }

            var result1 = from e in emp
                          where e.DeptName.Contains("HR")
                          select e;

            foreach (EmployeeDetails e in result1)
            {
                Console.WriteLine(e);
            }


            var result3 = from e in emp
                          orderby e.Salary descending
                          select e;

            foreach (EmployeeDetails e in result3)
            {
                Console.WriteLine(e);
            }

            var result4 = from e in emp
                          where e.EmpName.StartsWith("p")
                          select e;

            foreach (EmployeeDetails e in result4)
            {
                Console.WriteLine(e);
            }

            var result5 = from e in emp
                          where e.DeptName.Contains("Dev")
                          orderby e.EmpName
                          select e;
            foreach (EmployeeDetails e in result5)
            {
                Console.WriteLine(e);
            }


            var result6 = from e in emp
                          where e.Salary >= 20000 && e.Salary <= 35000
                          select e;
            foreach (EmployeeDetails p in result6)
            {
                Console.WriteLine(p);
            }
        }
    }
}
