using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public class Employee
    {
        protected string name;
        protected int id;

        protected static int count;
        protected string country;
        protected double basic, hra, da, pf, gross;
        public Employee(string name, double basic, string country = "India")
        {
            count++;
            id = count;
            this.name = name;
            //  this.salary = salary;
            this.basic = basic;
            this.country = country;

        }
        public virtual void CalculateSal()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da) - pf;
        }
        public override string ToString()
        {
            return $"{id}-->{name}-->{gross}-->{country}";
        }

        public double GetGrossSal()
        {
            return gross;
        }

    }
   
    
}

