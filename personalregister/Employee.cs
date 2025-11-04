using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personalregister
{
    internal class Employee
    {

        public String firstName;
        public String lastName;
        public decimal salary;

        public Employee(string firstName, string lastName, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public void employeeToString()
        {
            Console.WriteLine(" employee");
        }
    }
}
