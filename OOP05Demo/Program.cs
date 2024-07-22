using OOP05Demo.Operator_Overloading;
using System.Net.Http.Headers;

namespace OOP05Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex() { Real = 3 , Imag = 4 };
            Complex c2 = new Complex() { Real = 2, Imag = 7 };

            #region Binary operators
            //Complex c3 =  c1 + c2;
            //Complex c4 = c1 - c3;
            //Console.WriteLine(c3); 
            #endregion

            #region Unary operators
            //Complex c3 = c2;
            //Console.WriteLine("Before : ");
            //Console.WriteLine(c1.GetHashCode());
            //Console.WriteLine(c3.GetHashCode());

            //Console.WriteLine(c1);
            //Console.WriteLine(c3);

            //c3 = c1++; // will create a new object
            //Console.WriteLine("After post fix");
            //Console.WriteLine(c1.GetHashCode());
            //Console.WriteLine(c3.GetHashCode());

            //Console.WriteLine(c1);
            //Console.WriteLine(c3);

            //c3 = ++c1; 

            //Console.WriteLine("After prefix: ");
            //Console.WriteLine(c1.GetHashCode());
            //Console.WriteLine(c3.GetHashCode());

            //Console.WriteLine(c1);
            //Console.WriteLine(c3); 
            #endregion

            #region comparison operator
            //if (c1 > c2)
            //    Console.WriteLine("c1 is greater");
            //else if (c2 > c1)
            //    Console.WriteLine("c2 is greater");
            //else
            //    Console.WriteLine("Both are equal");
            #endregion
                    
            #region casting operator overloading
            //long x = 50;
            //int y = (int)x; // casting operator
            //int z = (int)c1;
            //Console.WriteLine(z);

            //string str = c2; // implicit
            //Console.WriteLine(str); 
            #endregion




        }
    }
}
