using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public enum Dept { HR, Admin, Sales, Development, Testing, Manager}
    public class EnumClasses
    {
        protected int eid;
        protected string ename;
        protected double basic , hra, da, pf, gross;
        private Dept dept;
        
        public EnumClasses(int eid, string ename, double basic,Dept dept)
        {
            this.eid = eid;
            this.ename = ename;
            this.basic = basic;
            this.dept = dept;
        }
        public void Calc()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (hra + da + basic) - pf;

        }
        public override string ToString()
        {
            return $"Employee id {eid}  Employee name {ename}  Gross Salary  {gross}  {dept}";
        }

    }
}
