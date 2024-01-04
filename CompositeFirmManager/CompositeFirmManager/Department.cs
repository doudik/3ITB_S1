using System.Globalization;

namespace CompositeFirmManager
{
    public class Department : IAcessible
    {
        public string nameDeparment { get; private set; }
        public List<IAcessible> employees { get; private set; } = new List<IAcessible>();

        public Department(string nameDeparment)
        {
            this.nameDeparment = nameDeparment;
        }

        public void Add(IAcessible employee)
        {
            employees.Add(employee);
        }

        public void Remove(IAcessible employee)
        {
            employees.Remove(employee);
        }
        public void GetAllInformation()
        {
            Console.WriteLine($"Department {nameDeparment} has {employees.Count} employees.");
            foreach (Employee item in employees)
            {
                Console.WriteLine($"Employee {item.name} in position {item.position} has salary {item.salary}$.");
            }
            Console.WriteLine();
        }
    }
}