using System;
using System.Collections.Generic;
using System.Linq;


namespace Books_Prject
{
    internal class EmployeeDetails
    {
        public int Eid { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public string  DeptName { get; set; }

        public override string ToString()
        {
            return $"id --> {Eid} , Employee Name --> {EmpName} , Salary --> {Salary} , Department --> {DeptName}";    
        }
    }
   
}
