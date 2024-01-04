using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFirmManager
{
    internal class Company : IAcessible
    {
        public string companyName { get; private set; }
        public List<IAcessible> departments { get; private set; } = new List<IAcessible>();

        public Company(string companyName)
        {
            this.companyName = companyName;
        }

        public void Add(IAcessible department)
        {
            departments.Add(department);
        }


        public void Remove(IAcessible department)
        {
            departments.Remove(department);
        }
        public void GetAllInformation()
        {
            Console.WriteLine($"Company {companyName} has {departments.Count} departments.");
            Console.WriteLine("These are the departments with all information:");
            foreach (Department item in departments)
            {
                item.GetAllInformation();
            }
        }
    }
}
