using CompositeCompany;

namespace CompositeCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company SPSUL = new Company("SPŠUL");

            Department IT = new Department("IT");
            Department CJL = new Department("CJL");
            Department MAT = new Department("MAT");

            SPSUL.Add(IT);
            SPSUL.Add(CJL);
            SPSUL.Add(MAT);

            List<Employee> employees = new List<Employee>() { 
                new Employee("Petr Kejklíček", IT),
                new Employee("Karolína Černá", IT),
                new Employee("Vojta Krucký", IT),
                new Employee("Ondra Krucký", IT),
                new Employee("Dominik Vinš", IT),
                new Employee("Patrik Carska", MAT),
                new Employee("Ondřej Jareš", MAT),
                new Employee("Tomáš Bešťák", MAT),
                new Employee("David Hadupyak", MAT),
                new Employee("Jan Divíšek", MAT),
                new Employee("Jakub Mičán", CJL),
                new Employee("Matěj Kovařík", CJL),
                new Employee("Matyáš Šorf", CJL),
                new Employee("Adam Stiburek", CJL),
                new Employee("Jiří Hilš", CJL)
            };
            foreach (Employee emp in employees)
            {
                if(emp.department == IT)
                {
                    IT.Add(emp);
                }
                else if(emp.department == CJL)
                {
                    CJL.Add(emp);
                }
                else if(emp.department == MAT)
                {
                    MAT.Add(emp);
                }
            }
            SPSUL.GetAllInformation();
        }
    }
}