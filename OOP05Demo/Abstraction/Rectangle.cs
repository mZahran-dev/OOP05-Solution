using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05Demo.Abstraction
{
    internal class Rectangle : RectBase // inherit & implement
    {
        public override double perimeter
        {
            get { return (Dim01 + Dim02) * 2; }
        }

        // concrete class : concrete class [inherits]
        // concrete class : interface [implements]
        // concrete class : abstract class [inherits & implements]
        public override double CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
}
