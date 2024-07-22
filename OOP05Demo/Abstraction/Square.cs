using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP05Demo.Abstraction
{
    internal class Square : RectBase
    {
        public override double perimeter
        {
            get { return Dim01 * 4; }
        }

        public override double CalcArea()
        {
            return Dim01 * Dim02;
           
        }
    }
}
