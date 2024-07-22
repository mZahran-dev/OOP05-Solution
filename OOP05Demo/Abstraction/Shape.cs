using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05Demo.Abstraction
{
    //Abstract class => partial implementation for other classes
        // you can not create object from abstract class 
        // because abstract class is not fully implemented
    internal abstract class Shape
    {
        public double Dim01 { get; set; }   
        public double Dim02 { get; set; }
        public abstract double perimeter
        {
            get;
        }

        public abstract double CalcArea(); //partial implemention
    }
}
