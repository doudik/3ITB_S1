using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFirmManager
{
    internal class Employee : IAcessible
    {
        public string name { get; private set; }
        public float salary { get; private set; }
        public string position { get; private set; }
        public Department department { get; set; }

        Random rnd = new Random();

        public Employee(string name, string position, Department department)
        {
            this.name = name;
            salary = rnd.Next(0, 100000);
            this.position = position;
            this.department = department;
        }

        public void Add(IAcessible accessible)
        {
            throw new NotImplementedException();
        }

        public void Remove(IAcessible accessible)
        {
            throw new NotImplementedException();
        }

        public void GetAllInformation()
        {
        }
    }
}
