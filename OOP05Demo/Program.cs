using OOP05Demo.Abstraction;
using OOP05Demo.Casting_operator_buisness_need;
using OOP05Demo.Operator_Overloading;
using OOP05Demo.Partial;
using OOP05Demo.Sealed;
using OOP05Demo.Static;
using System.Net.Http.Headers;

namespace OOP05Demo
{
    internal class Program
    {
        public static void Print(PaymentProcessor payment , double amount)
        {
            payment.processPayment(amount);
        }
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

            #region Casting operator buisness need
            //mapping from ref type to ref type

            //Employee employee = new Employee()
            //{
            //    Id = 1,
            //    FullName = "Mahmoud Ibrahim",
            //    Email = "Mahmoud@gmail.com",
            //    Password = "password"

            //};
            //EmployeeViewModel employeeViewModel = (EmployeeViewModel)employee;
            //Console.WriteLine(employeeViewModel.FirstName);
            //Console.WriteLine(employeeViewModel.LastName); 
            #endregion

            #region Abstraction
            //Rectangle r1 = new Rectangle()
            //{
            //    Dim01 = 10,
            //    Dim02 = 20
            //};
            //Console.WriteLine(r1.CalcArea());
            //Console.WriteLine(r1.perimeter);

            //Circle c = new Circle(10);
            //Console.WriteLine(c.CalcArea()); 
            #endregion

            #region Static Keyword
            //Utility u1 = new Utility(1, 2);
            //Utility u2 = new Utility(2, 3);

            //Console.WriteLine(Utility.CmToInch(10));
            //Console.WriteLine(Utility.CmToInch(10));

            //Console.WriteLine("*****************");

            //Console.WriteLine(Utility.CalCircleArea(10));
            //Console.WriteLine(Utility.CalCircleArea (10));
            //Console.WriteLine(Utility.Pi);

            //Utility u1 = new Utility(1, 2);
            //Utility u2 = new Utility(2, 3);
            //Console.WriteLine(Guid.NewGuid()); 
            #endregion


            #region Sealed [Class , Propety, Method]
            //PaymentProcessor paymentProcessor = new PaymentProcessor();
            //InheritPayment payment = new InheritPayment();
            //paymentProcessor.processPayment(10);
            //payment.processPayment(20); 
            #endregion


            #region Partial Class
            //Person p1 = new Person()
            //{
            //    Id = 1,
            //    Name = "Test",
            //    Age = 20,
            //    salary = 2000
            //}; 
            #endregion







        }
    }
}
