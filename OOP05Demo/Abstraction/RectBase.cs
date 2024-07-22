using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05Demo.Abstraction
{
    internal abstract class RectBase : Shape
    {
        //public override double perimeter
        public override double CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
}
