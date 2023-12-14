using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeCompany
{
    internal class Employee : ICompany
    {
        public float salary { get; private set; }
        public string name { get; private set; }
        public Department department { get; private set; }
        Random rnd = new Random();
        

        public Employee(string name, Department dep)
        {
            this.name = name;
            this.salary = rnd.Next(0, 200000);
            department = dep;
        }

        public void Add(ICompany item)
        {
            throw new NotImplementedException();
        }

        public void Remove(ICompany item)
        {
            throw new NotImplementedException();
        }

        public void GetAllInformation()
        {
            throw new NotImplementedException();
        }
    }
}
