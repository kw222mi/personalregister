using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personalregister
{
    internal class PersonnelRegister
    {
        private readonly List<Employee> _employees = new();

        public void Add(Employee e) => _employees.Add(e);

        public IEnumerable<Employee> All() => _employees;

        public void PrintAll()
        {

        }
    }
}
