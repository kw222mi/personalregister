using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace personalregister
{
    internal class Employee
    {
      
        public string FirstName { get;  }
        public string LastName { get; }
        public decimal Salary { get; }

        public Employee(string firstName, string lastName, decimal salary)

        {
         

            this.FirstName = firstName.Trim();
            this.LastName = lastName.Trim();
            this.Salary = salary;
        }

        public override string ToString()
       => $"{FirstName,-15} {LastName,-15} {Salary,12:C}";
        
        
    }
}
