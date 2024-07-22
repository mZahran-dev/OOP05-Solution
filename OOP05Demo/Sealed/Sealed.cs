using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05Demo.Sealed
{

    sealed class PaymentProcessor
    {
        public void processPayment(double amount)
        {
            Console.WriteLine($" Amount = {amount * 10}");
        }
    }


    //class InheritPayment : PaymentProcessor
    //{
    //    public override void processPayment(double amount)
    //    {
    //        Console.WriteLine($" Amount = {amount * 20}");
    //    }
    //}

    

    internal class Parent
    {
         public  virtual void Print()
         {
            Console.WriteLine("I am Base");
         }

        private  double salary;

        public virtual double Salary
        {
            get { return salary; }
            set { salary = value - 1000; }
        }

    }

    internal class Child : Parent
    {
        // sealed property : cannot be overriden 
        public sealed override double Salary
        { 
            get => base.Salary; 
            set => base.Salary = value - 2000; 
        }
        public sealed override void Print()
        {
            base.Print();
        }

    }

    // sealed class : class that cannot be inherit from
    sealed class GrandChild: Child { }

    //internal class Test : GrandChild { }
}
