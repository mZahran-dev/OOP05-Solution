using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05Demo.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        //Function must be non-private and static [Class member method]

        //binary operator
        public static Complex operator +(Complex left,  Complex right)
        {
            return new Complex 
            {
                Real = (left?.Real ?? 0 + right?.Real?? 0),
                Imag = (left?.Imag ?? 0 + right?.Imag ?? 0)
            };

        }
       
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0 - right?.Real ?? 0),
                Imag = (left?.Imag ?? 0 - right?.Imag ?? 0)
            };

        }

        //unary operator
        public static Complex operator ++(Complex complex)
        {
            return new Complex
            {
                Real = (complex?.Real ?? 0 ) + 1,
                Imag = (complex?.Imag ?? 0)  
            };

        }
        
        //Comparison operators
        public static bool operator > (Complex left, Complex right)
        {
            if(left?.Real == right?.Real) 
                return left?.Imag > right?.Imag;
            else
                return left?.Real > right?.Real;
        }
        public static bool operator < (Complex left, Complex right)
        {
            if (left?.Real == right?.Real)
                return left?.Imag < right?.Imag;
            else
                return left?.Real < right?.Real;
        }

        //casting operators
        public static explicit operator int(Complex complex)
        {
            return complex?.Real??0;
        }
        public static implicit operator string(Complex complex)
        {
            return complex?.ToString() ?? string.Empty;
        }

    }
}
