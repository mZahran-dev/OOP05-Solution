using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05Demo.Static
{
    internal static class Utility
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        //static attribute
        // compiler will initialize static attribute with default value = 0 

        //private static double pi = 3.14;

        //class member property [static]
        // 1. static attributes
        // 2. constant

        private const double PI = 3.14;
        public static double Pi
        {
            get { return PI ; }
            //set { pi = value; }  read only
        }

        //object member constructor
        //public Utility(int _x , int _y) 
        //{
        //    X = _x;
        //    Y = _y;
        //}
        //static constructor
        // has no access modifier
        // has no parameters

        //static Utility()
        //{
        //    // initialize for static members
        //    // max class have one static constructor
        //    // CLR will call static constructor with the first usage of class

        //    //Usage
        //    // 1. Create object from Class
        //    // 2. create object from a Child Class
        //    // 3. Call static method 
        //    // 4. Call static property
        //    PI = 3.14;
        //}


        //public override string ToString()
        //{
        //    return $"{X} {Y}";
        //}

        // Class member method [static]
        // the result of calling the method "cmToInch" will not deffer 
        // by the difference of object state [data (x,y)]

        public static double CmToInch(double cm)
        {
            return cm * 2.54;
        }
        public static double CalCircleArea(double radius)
        {
            return PI* Math.Pow(radius, 2);
        }
    }
}
