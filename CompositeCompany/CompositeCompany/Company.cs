using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeCompany
{
    internal class Company : ICompany
    {
        public string companyName { get; private set; }
        List<ICompany> departments;

        public Company(string companyName)
        {
            this.companyName = companyName;
            departments = new List<ICompany>();
        }

        public void Add(ICompany item)
        {
            departments.Add(item);
        }
        public void Remove(ICompany item)
        {
            departments.Remove(item);
        }

        public void GetAllInformation()
        {
            foreach (Department item in departments)
            {
                Console.WriteLine($"Department {item.departmentName} has {item.numberOfEmployees} employees:");
                item.GetAllInformation();
            }
        }

    }
}
