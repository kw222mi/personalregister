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
            Console.WriteLine();
            Console.WriteLine("PERSONALREGISTER");
            Console.WriteLine(new string('-', 45));
            Console.WriteLine($"{"Förnamn",-15} {"Efternamn",-15} {"Lön",12}");
            Console.WriteLine(new string('-', 45));

            foreach (var item in _employees)
            {
                Console.WriteLine(item.ToString());

            } 

            if (_employees.Count > 0)
            {
                Console.WriteLine(new string('-', 45));
            }
            else
            {
                Console.WriteLine("Inga anställda inlagda ännu.");
            }
            Console.WriteLine();

        }
    }
}
