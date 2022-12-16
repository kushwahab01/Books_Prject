using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    abstract public class Shape
    {
        public abstract void CalculateArea();
    }
    public class Rectangle : Shape
    {
        private int l;
        private int w;
        private double area;

        public Rectangle(int l,int w)
        {
            this.l = l;
            this.w = w;

        }
        public override void CalculateArea()
        {
            area = l * w;
        }
        public override string ToString()
        {
            return $"Area of rectangle is {area}";
        }

    }
}
