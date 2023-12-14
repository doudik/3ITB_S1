using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeCompany
{
    internal class Department : ICompany
    {
        public string departmentName { get; private set; }
        public List<ICompany> employees { get; private set; }
        public int numberOfEmployees { get; private set; }

        public Department(string departmentName)
        {
            this.departmentName = departmentName;
            employees = new List<ICompany>();
        }

        public void Add(ICompany item)
        {
            numberOfEmployees++;
            employees.Add(item);
        }

        public void Remove(ICompany item)
        {
            numberOfEmployees--;
            employees.Remove(item);
        }

        public void GetAllInformation()
        {
            foreach (Employee item in employees)
            {
                Console.WriteLine($"Employee {item.name} with salary of {item.salary}$");
            }
            Console.WriteLine();
        }
    }
}
