using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class EmployeeConstructor
    {
        private int id;
        private string name;
        private int salary;

       public EmployeeConstructor(int id,string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;


        }
        public override string ToString()
        {
            return $"{id}  {name}  {salary}";
        }
       
       
    }
    
}
