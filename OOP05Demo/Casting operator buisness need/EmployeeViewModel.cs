using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05Demo.Casting_operator_buisness_need
{
    //View Model => class that will be rendered by views[html]
    internal class EmployeeViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public static explicit operator EmployeeViewModel(Employee emp)
        {
            string[]Names = emp?.FullName?.Split(' ');
            return new EmployeeViewModel()
            {
                ////manual mapping
                FirstName = Names?.Length > 0 ? Names[0] : string.Empty,
                LastName = Names?.Length > 0 ? Names[1] : string.Empty,
                Email = emp?.Email ?? string.Empty

            };


        }
    }
}
