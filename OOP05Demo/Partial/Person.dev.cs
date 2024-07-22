using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05Demo.Partial
{
    partial class Person
    {
        public decimal salary { get; set; }

        partial void Print()
        {
            Console.WriteLine("Hello partial");
        }
    }
}
