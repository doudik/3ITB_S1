namespace CompositeFirmManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company SPSUL = new Company("SPSUL");
            
            Department IT = new Department("IT");
            Department mathematicans = new Department("MAT");
            Department czechLang = new Department("CJL");

            List<IAcessible> employeesLocal = new List<IAcessible>() {
                new Employee("Petr", "Programmer", IT),
                new Employee("Jan", "Programmer", IT),
                new Employee("Jana", "Programmer", IT),
                new Employee("Jirka", "Programmer", IT),
                new Employee("Pavel", "Programmer", IT),
                new Employee("Karel", "Programmer", IT),
                new Employee("Jitka", "Mathematicator", mathematicans),
                new Employee("Jana", "Mathematicator", mathematicans),
                new Employee("Jirka", "Mathematicator", mathematicans),
                new Employee("Pavel", "Mathematicator", mathematicans),
                new Employee("Karel", "Mathematicator", mathematicans),
                new Employee("Jitka", "CzechLangTeacher", czechLang),
                new Employee("Jana", "CzechLangTeacher", czechLang),
                new Employee("Jirka", "CzechLangTeacher", czechLang),
                new Employee("Pavel", "CzechLangTeacher", czechLang),
                new Employee("Karel", "CzechLangTeacher", czechLang)
            };
            foreach (Employee item in employeesLocal)
            {
                item.department.Add(item);
            }

            SPSUL.Add(IT);
            SPSUL.Add(mathematicans);
            SPSUL.Add(czechLang);

            SPSUL.GetAllInformation();
        }
    }
}