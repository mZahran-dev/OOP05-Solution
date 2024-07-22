using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05Demo.Abstraction
{
    internal class Circle : Shape
    {
        public Circle(double radius) 
        {
            Dim01 = Dim01 = radius;
        }
        public override double perimeter
        {
            get { return 2 * Dim01 * Math.PI; }
            
        }
        public override double CalcArea()
        {
            return Math.PI * Dim01 * Dim01;
        }
    }
}
