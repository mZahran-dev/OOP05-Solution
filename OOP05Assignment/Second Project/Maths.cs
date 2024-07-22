using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05Assignment.Second_Project
{
    internal static class Maths
    { 
        public static double Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Subtract(int num1, int num2)
        {
            return num1 - num2;
            
        }

        public static double Multiply(int num1, int num2)
        { 
            return num1 * num2; 
        }

        public static double Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }
}
